# Unreal & Unity Robot Interaction Assignment

This repository contains my implementation of the robot interaction project in **Unreal Engine 5.6** and the related **unit test in Unity** as requested.

---

# Repository Structure

/UnrealProject

├── /ForgeFXDemoGPUBaked → Unreal Engine project using GPU Lightmass

├── /ForgeFXDemoLumen → Unreal Engine project using Lumen lighting

│
/UnityTest

├── RobotArm.cs → Main robot arm class

├── RobotArmTests.cs → Unit test script using Unity Test Framework

---

# How to Run the Unreal Projects

1. Open **Unreal Engine 5.6**.
2. Open the `.uproject` file inside either:
   - `/UnrealProject/Lumen/`
   - `/UnrealProject/Lightmass/`
3. Once the editor loads, click **Play** in the viewport.
4. The application was designed for full screen use. This can be done by pressing "F11".
5. Controls are included in the project. Simply navigate to the controls section of the UI or pause menu, Press "P" to pause the running demo for options.

> All requirements (camera control, robot interaction, highlighting, attachment, detachment, UI status) are implemented and working.

---

## Unity Unit Test Instructions

1. Open **Unity**.
2. Create a new 3D project (if needed).
3. Import `RobotArm.cs` and `RobotArmTests.cs` from the `/UnityTest` folder (both should be in the same folder).
4. Open **Test Runner** (Window → General → Test Runner).
5. Run the test in **Play Mode**.
6. The test should **pass under normal conditions** and **fail** if the `IsAttached` state is modified incorrectly.

---

## Project Features (Unreal)

- Camera control via keyboard input
- Interactive robot highlighting using material swap
- Mouse-controlled robot dragging
- Arm detachment and reattachment
- Status HUD displaying "Attached" or "Detached"
- Clean blueprint structure with modular logic
- Commented nodes and readable structure
- Two lighting setups (Lumen and Lightmass)

---

## Notes

- Only `.cs` (C#) files are included for Unity, no scenes or assets.
- Files are separated for clarity and review.
- This repo is public for demonstration purposes as requested.

---
