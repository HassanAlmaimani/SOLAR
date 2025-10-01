# SOLAR: The AR Solar System 🪐

A lightweight Android app that drops our solar system on your desk in augmented reality.  
Built with Unity + AR Foundation + ARCore.

<img width="1261" height="720" alt="image" src="https://github.com/user-attachments/assets/e104faa0-61de-4bdc-a79c-d0150c1a4eaf" />

## Features
- Realistic relative sizes (distances are compressed so it fits in your room)  
- Tap a planet → name + fun fact overlay  
- Orbit animation that runs at 30 000 × real-time (a full Earth year = ~17 s)  
- No server calls, no accounts, no tracking – works completely offline  

## Tech stack
- Unity 2022.3.62f1 LTS  
- AR Foundation (ARCore)  
- Mixed Lighting / URP  
- C# scripts only; zero native plugins  

## Install & Run
1. Clone or download this repo  
2. Open the `SOLAR` folder as a Unity project  
3. Switch platform to Android (File → Build Settings)  
4. Open **Project Settings → XR Plug-in Management** and enable  
   - Android: ARCore  
5. Build & run on a device (requires Android 7.0+ with ARCore support)

## Folder snapshot
<img width="599" height="722" alt="image" src="https://github.com/user-attachments/assets/d4a6051f-cc78-4c33-8e48-91056681289c" />

## Customising
- **Distance & speed**: tweak the public variables on the `Planet Orbit` script components in each planet  

## License
MIT – do whatever you want, just don’t blame me if Pluto is still not a planet.

## Credits
- Planet 3D Assets by [Evgenii Nikolskii](https://assetstore.unity.com/publishers/21782)
