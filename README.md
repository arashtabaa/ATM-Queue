# ATM Queue Management
![ATM-Queue](https://github.com/arashtabaa/ATM-Queue/assets/153722318/5fd39bac-d82a-4c58-bea5-d30da0992f10)

♻️ **Description**:
ATM Queue Management is a Windows Forms application that simulates the management of an ATM queue. It allows users to add and remove people from the queue, visually displaying the queue status and updating progress bars and labels dynamically.

## ⚓ Features

### Queue Management
- **Add to Queue**: Add a person to the queue, displaying them in a `FlowLayoutPanel` with an associated label.
- **Remove from Queue**: Remove the person at the front of the queue, updating the display accordingly.
- **Queue Visuals**: Show images representing people in the queue, shifting images to reflect the queue status.
- **Progress Bar**: Update a progress bar to reflect the current queue occupancy.
- **Front and Rear Indicators**: Dynamically update labels indicating the front and rear positions in the queue.

## 💎 Usage

### Queue Operations
- **Adding a Person**: Click the 'Enqueue' button to add a person to the queue. If the queue is full, a message box will alert the user.
- **Removing a Person**: Click the 'Dequeue' button to remove the person at the front of the queue. If the queue is empty, a message box will alert the user.

### Visual Updates
- **Label Addition**: Adds a label with a person icon and their number to the `FlowLayoutPanel` when they are added to the queue.
- **Image Shifting**: Shifts images in the `PictureBox` array to the right when a person is removed from the queue, maintaining the visual order.
- **Progress Bar Update**: Adjusts the progress bar to indicate the percentage of the queue that is currently filled.
- **Label Updates**: Updates the `Front` and `Rear` labels to show the current positions in the queue.

## ✅ Installation

1. Clone the repository from GitHub:
    ```sh
    git clone https://github.com/arashtabaa/ATM-Queue.git
    ```
2. Open the solution file `ATM-Queue.sln` in Visual Studio.
3. Build and run the project.

## 💫 Requirements

- Visual Studio 2019 or later
- .NET Framework 3.5
- C# 9.0

## 📍 Contributing

- Feel free to submit issues and enhancement requests.
- Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## 🪪 License

- This project is licensed under the MIT License. See the [LICENSE](https://github.com/arashtabaa/ATM-Queue/tree/main?tab=MIT-1-ov-file#) file for more information.

## ✍️ Author

- Arash Tabatabaei - [arashtabaa](https://github.com/arashtabaa)
