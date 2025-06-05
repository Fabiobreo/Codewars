using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    public class BattleshipField
    {
        public static bool ValidateBattlefield(int[,] field)
        {
            int rows = 10;
            int cols = 10;
            bool[,] visited = new bool[rows, cols];

            // Ship counts: index 0 for size 1, index 1 for size 2, etc.
            int[] shipCounts = new int[4]; // For sizes 1, 2, 3, 4

            // Directions for checking 8 neighbors (including diagonals) for contact
            int[] dr8 = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dc8 = { -1, 0, 1, -1, 1, -1, 0, 1 };

            // Directions for BFS traversal (only horizontal and vertical)
            int[] dr4 = { 0, 0, 1, -1 };
            int[] dc4 = { 1, -1, 0, 0 };

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (field[i, j] == 1 && !visited[i, j])
                    {
                        // Found a potential start of an unvisited ship
                        List<(int, int)> currentShipCells = new List<(int, int)>();
                        Queue<(int, int)> queue = new Queue<(int, int)>();

                        queue.Enqueue((i, j));
                        visited[i, j] = true;
                        currentShipCells.Add((i, j));

                        // BFS to find all connected ship cells (horizontally or vertically)
                        while(queue.Count > 0)
                        {
                            var current = queue.Dequeue();
                            int r = current.Item1;
                            int c = current.Item2;

                            for(int move = 0; move < 4; move++) // Only traverse horizontally/vertically
                            {
                                int nr = r + dr4[move];
                                int nc = c + dc4[move];

                                // Check bounds, if neighbor is a ship cell and hasn't been visited yet
                                if (nr >= 0 && nr < rows && nc >= 0 && nc < cols && field[nr, nc] == 1 && !visited[nr, nc])
                                {
                                    visited[nr, nc] = true;
                                    currentShipCells.Add((nr, nc));
                                    queue.Enqueue((nr, nc));
                                }
                            }
                        }

                        int shipSize = currentShipCells.Count;

                        // Validate ship size (must be between 1 and 4)
                        if (shipSize < 1 || shipSize > 4) return false;

                        // Validate ship shape (must be a straight line for size > 1)
                        if (shipSize > 1)
                        {
                            bool allSameRow = true;
                            bool allSameCol = true;
                            int firstRow = currentShipCells[0].Item1;
                            int firstCol = currentShipCells[0].Item2;

                            // Check if all cells are on the same row or same column
                            for(int cellIdx = 1; cellIdx < currentShipCells.Count; cellIdx++)
                            {
                                if (currentShipCells[cellIdx].Item1 != firstRow) allSameRow = false;
                                if (currentShipCells[cellIdx].Item2 != firstCol) allSameCol = false;
                            }

                            // A ship of size > 1 must be either purely horizontal or purely vertical
                            if (!allSameRow && !allSameCol) return false;

                            // Check for consecutive cells along the line
                            if(allSameRow) // Horizontal ship
                            {
                                // Sort cells by column to check for consecutiveness
                                currentShipCells.Sort((a, b) => a.Item2.CompareTo(b.Item2));
                                for(int cellIdx = 0; cellIdx < currentShipCells.Count - 1; cellIdx++)
                                {
                                    // If columns are not consecutive, shape is invalid
                                    if (currentShipCells[cellIdx].Item2 + 1 != currentShipCells[cellIdx + 1].Item2) return false;
                                }
                            }
                            else // Vertical ship (allSameCol must be true)
                            {
                                // Sort cells by row to check for consecutiveness
                                currentShipCells.Sort((a, b) => a.Item1.CompareTo(b.Item1));
                                for(int cellIdx = 0; cellIdx < currentShipCells.Count - 1; cellIdx++)
                                {
                                    // If rows are not consecutive, shape is invalid
                                    if (currentShipCells[cellIdx].Item1 + 1 != currentShipCells[cellIdx + 1].Item1) return false;
                                }
                            }
                        }

                        // Increment the count for the identified ship size
                        shipCounts[shipSize - 1]++;

                        // Contact check for all cells of the current ship against all 8 neighbors
                        foreach (var cell in currentShipCells)
                        {
                            int r = cell.Item1;
                            int c = cell.Item2;

                            for (int move = 0; move < 8; move++) // Check all 8 directions (including diagonals)
                            {
                                int nr = r + dr8[move];
                                int nc = c + dc8[move];

                                // Check bounds
                                if (nr >= 0 && nr < rows && nc >= 0 && nc < cols)
                                {
                                    // If a neighbor is a ship cell (1)
                                    if (field[nr, nc] == 1)
                                    {
                                        // Check if this neighbor cell is part of the *current* ship being validated.
                                        // If it's not part of the current ship, it means there is contact
                                        // (either diagonal or touching the end of another ship).
                                        bool isNeighborPartOfCurrentShip = false;
                                        foreach(var shipCell in currentShipCells)
                                        {
                                            if(shipCell.Item1 == nr && shipCell.Item2 == nc)
                                            {
                                                isNeighborPartOfCurrentShip = true;
                                                break;
                                            }
                                        }

                                        if (!isNeighborPartOfCurrentShip)
                                        {
                                            return false; // Illegal contact with another ship
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // Final check of the total number of ships of each size
            if (shipCounts[0] != 4) return false; // Must have 4 submarines (size 1)
            if (shipCounts[1] != 3) return false; // Must have 3 destroyers (size 2)
            if (shipCounts[2] != 2) return false; // Must have 2 cruisers (size 3)
            if (shipCounts[3] != 1) return false; // Must have 1 battleship (size 4)

            // If all checks passed, the battlefield is valid
            return true;
        }
    }
}
