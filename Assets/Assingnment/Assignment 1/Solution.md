# Q1

## Setup for Transparency, Lighting, and Shadow Casting in Unity

### a. Adding a Semi-Transparent Sheet Above the Plane
1. **Creating the Transparent Sheet:**
    - Create a new plane in Unity.
    - Create a new cube place it above plane change its size to make it like a thin sheet.
    - Create a new material for the transparent sheet.
    - Change the **Rendering Mode** of the material to `Transparent`.
    - Adjust the **Albedo** color and set the alpha (transparency) value to less than `0.5`.
    - Apply this material to the plane to create a semi-transparent sheet.

2. **Ensuring No Physics Interference:**
    - Ensure that the transparent sheet does not have a `Collider` component if you don’t want it to interfere with the physics of the cubes.
   
### b. Placing a Directional Light for Shadow Casting
1. **Adding the Directional Light:**
    - Create a `Directional Light` in the scene.
    - Position the light so that it casts shadows from the cubes onto the plane.
    - Adjust the rotation of the light to achieve the desired shadow direction.
    - Adjust the **Shadow Strength** to control the darkness of the shadows.

### c. Enabling Shadow Casting for Particle Systems
1. **Creating a Particle System:**
    - Add a `Particle System` to the scene.
    - Position the particle system above or around the plane where you want the shadows to be cast.

2. **Enabling Shadow Casting:**
    - In the **Renderer** module of the particle system, set the `Cast Shadows` option to `On`.
    - Ensure the material used by the particle system is capable of casting shadows. Default particle material can't cast shadow.
    - Adjust the particle system settings (e.g., particle size, emission rate) to ensure the particles cast noticeable shadows on the plane.


---

# Q4

## A Brief History of VR Technology (1935 - Present)

### 1935: The Concept of VR
- **"Pygmalion's Spectacles" (1935)**: The concept of virtual reality (VR) started with a short story by Stanley G. Weinbaum called "Pygmalion's Spectacles," which described a goggle-based system that provided users with immersive experiences, including sight, sound, smell, and touch.

### 1960s: The First VR Devices
- **Sensorama (1962)**: Morton Heilig developed the Sensorama, a mechanical device that provided an immersive experience with 3D visuals, sound, vibrations, and smells. it was an early attempt at creating a multisensory experience.
- **The Sword of Damocles (1968)**: Created by Ivan Sutherland and his student Bob Sproull, this was the first head-mounted display (HMD) system that showed simple computer-generated graphics. It was a significant milestone in VR technology, though it was bulky and not user-friendly.

### 1990s: Commercial VR Attempts
- **Virtuality Group (1991)**: This company introduced the first mass-produced, multiplayer VR entertainment systems. These arcade machines featured VR headsets and real-time, interactive experiences.
- **Sega VR and Nintendo Virtual Boy (1990s)**: Both Sega and Nintendo attempted to bring VR to the gaming market with the Sega VR headset and the Nintendo Virtual Boy, respectively. However, these products were commercial failures due to technical limitations and discomfort.

### 2000s: Advances in Technology and Renewed Interest
- **CAVE Systems**: In the early 2000s, CAVE (Cave Automatic Virtual Environment) systems were developed for scientific and industrial applications, providing room-sized environments where users could experience VR without headsets.
- **Military and Medical Applications**: VR was increasingly used in military training and medical simulations, offering safe environments for practice.

### 2010s: The Rise of Consumer VR
- **Oculus Rift (2012)**: The launch of the Oculus Rift Kickstarter campaign reignited interest in VR. Oculus, founded by Palmer Luckey, provided a high-quality VR experience at a relatively affordable price, leading to widespread adoption.
- **HTC Vive and PlayStation VR (2016)**: The release of the HTC Vive and PlayStation VR further established VR in the consumer market, offering immersive gaming experiences with improved tracking and motion controls.

### 2020s: Modern VR and the Metaverse
- **Standalone VR Headsets**: The Oculus Quest series (starting in 2019) marked the transition to standalone VR headsets that do not require a PC or console, making VR more accessible.
- **Metaverse and Social VR**: The concept of the metaverse, popularized by companies like Facebook (now Meta), focuses on creating interconnected virtual worlds where users can socialize, work, and play. VR technology is central to this vision, with ongoing developments in VR hardware, software, and content creation.

### Present and Future:
- **Current Trends**: VR continues to evolve with advancements in hardware (e.g., lighter, more powerful headsets), content (e.g., more diverse and immersive experiences), and integration with other technologies like augmented reality (AR) and artificial intelligence (AI).
- **Future Prospects**: The future of VR includes potential developments in full-body tracking, more realistic haptic feedback, higher resolution displays, and more seamless integration into everyday life, particularly in education, healthcare, and entertainment.
