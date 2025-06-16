using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
​
public static class Kata
{
    private static AssemblyBuilder runtimeAssembly;
    private static ModuleBuilder moduleBuilder;
    
    static Kata()
    {
        AssemblyName aName = new AssemblyName("RuntimeAssembly");
        runtimeAssembly = AssemblyBuilder.DefineDynamicAssembly(aName, AssemblyBuilderAccess.Run);
        moduleBuilder = runtimeAssembly.DefineDynamicModule("RuntimeAssemblyModule");
    }
  
    public static bool DefineClass(string className, Dictionary<string, Type> properties, ref Type actualType)
    {
        var existingType = runtimeAssembly.GetType(className, false, false);
        if (existingType != null)
        {
            actualType = existingType;
            return false;
        }
      
        var typeBuilder = moduleBuilder.DefineType(className, TypeAttributes.Public);
      
        foreach (var prop in properties)
        {
            string propName = prop.Key;
            Type propType = prop.Value;
          
            FieldBuilder fieldBuilder = typeBuilder.DefineField("_" + propName, propType, FieldAttributes.Private);
          
            PropertyBuilder propertyBuilder = typeBuilder.DefineProperty(propName, PropertyAttributes.HasDefault, propType, null);
            
            // Getter
            MethodBuilder getterBuilder = typeBuilder.DefineMethod("get_" + propName, MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig,
                                                                  propType, Type.EmptyTypes);
            var ilGetter = getterBuilder.GetILGenerator();
            ilGetter.Emit(OpCodes.Ldarg_0);
            ilGetter.Emit(OpCodes.Ldfld, fieldBuilder);
            ilGetter.Emit(OpCodes.Ret);
          
            // Setter
            MethodBuilder setterBuilder = typeBuilder.DefineMethod("set_" + propName, MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig,
                                                                  null, new Type[] { propType });
            var ilSetter = setterBuilder.GetILGenerator();
            ilSetter.Emit(OpCodes.Ldarg_0);
            ilSetter.Emit(OpCodes.Ldarg_1);
            ilSetter.Emit(OpCodes.Stfld, fieldBuilder);
            ilSetter.Emit(OpCodes.Ret);
          
            propertyBuilder.SetGetMethod(getterBuilder);
            propertyBuilder.SetSetMethod(setterBuilder);
        }
      
        actualType = typeBuilder.CreateType();
        return true;
    }
}