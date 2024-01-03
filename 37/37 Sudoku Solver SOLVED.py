class Solution:
    def solveSudoku(self, board):
        def is_valid(board, row, col, num):
            # Check the number in the row
            for x in range(9):
                if board[row][x] == num:
                    return False

            # Check the number in the col
            for x in range(9):
                if board[x][col] == num:
                    return False

            # Check the number in the box
            start_row, start_col = row - row % 3, col - col % 3
            for i in range(3):
                for j in range(3):
                    if board[i + start_row][j + start_col] == num:
                        return False
            return True

        def solve(board):
            for i in range(9):
                for j in range(9):
                    if board[i][j] == '.':
                        for num in "123456789":
                            if is_valid(board, i, j, num):
                                board[i][j] = num  # Attempt this number for the spot
                                if solve(board):  # Recurse with this attempt
                                    return True
                                else:
                                    board[i][j] = '.'  # Revert the attempt
                        return False  # No valid numbers can be placed in this spot
            return True  # Sudoku is solved

        solve(board)
