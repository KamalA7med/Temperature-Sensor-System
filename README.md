# Temperature Sensor Monitoring System

A simple event-driven temperature monitoring system written in C#.  
This project demonstrates how to use events, delegates, and OOP concepts to build a system where multiple devices react to temperature changes in real time.

## Features
- Temperature sensor that raises an event when the temperature changes.
- Alarm device that triggers when temperature exceeds a threshold.
- Display screen that shows the current temperature.
- Demonstrates:
  - Event handling
  - Inheritance
  - Encapsulation
  - Observer design pattern
## How It Works
1. `TemperatureSensor` fires an event `Temperature_Chenged` whenever a new temperature is read.
2. Devices like `Alarm` and `DisplayScreen` subscribe to the sensor's event.
3. When the event fires, each device receives the new temperature reading.
4. The `Alarm` checks if the temperature exceeds its threshold.
5. The `DisplayScreen` prints the current temperature.
## Concepts Used
- C# Events and Delegates
- Observer Pattern
- OOP Principles

## License
This project is open-source and free to use for learning.


