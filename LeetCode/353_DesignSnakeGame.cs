/*
353. Design Snake Game

*/

// class SnakeGame {
// private int width, height, score;
// private vector<pair<int, int>> food, pos;


// public:
//     SnakeGame(int width, int height, vector<pair<int, int>> food) {
//         this->width = width;
//         this->height = height;
//         this->food = food;
//         score = 0;
//         pos.push_back({0, 0});
//     }
    
//     /** Moves the snake.
//         @param direction - 'U' = Up, 'L' = Left, 'R' = Right, 'D' = Down 
//         @return The game's score after the move. Return -1 if game over. 
//         Game over when snake crosses the screen boundary or bites its body. */
//     int move(string direction) {
//         auto head = pos.front(), tail = pos.back();
//         pos.pop_back();
//         if (direction == "U") --head.first;
//         else if (direction == "L") --head.second;
//         else if (direction == "R") ++head.second;
//         else if (direction == "D") ++head.first;
//         if (count(pos.begin(), pos.end(), head) || head.first < 0 || head.first >= height || head.second < 0 || head.second >= width) {
//             return -1;
//         }
//         pos.insert(pos.begin(), head);
//         if (!food.empty() && head == food.front()) {
//             food.erase(food.begin());
//             pos.push_back(tail);
//             ++score;
//         }
//         return score;
//     }

// }; 