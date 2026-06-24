"# Stickman-game" 
# Stickman-game

# Development Setup Guide

This project uses Unity and JetBrains Rider (Free Non-Commercial License) for development.

## Prerequisites

### 1. Install Unity Hub

Download and install Unity Hub:
https://unity.com/download

### 2. Install the Required Unity Version

1. Open Unity Hub.
2. Go to **Installs**.
3. Install the Unity version specified by this project.
4. Ensure the required build support modules are installed.

---

## Install JetBrains Rider (Free)

### Download Rider

Download Rider:
https://www.jetbrains.com/rider/

### Activate Free License

1. Open Rider.
2. Sign in with your JetBrains account.
3. Select **Free Non-Commercial Use**.

This license can be used for learning, hobby projects, and open-source projects.

---

## Clone the Project

```bash
git clone <repository-url>
cd <repository-folder>
```

---

## Open the Project in Unity

1. Open Unity Hub.
2. Click **Add Project**.
3. Select the project root folder.

The root folder should contain:

```text
Assets/
Packages/
ProjectSettings/
```

4. Wait for Unity to finish importing assets.

---

## Configure Rider as the Default IDE

In Unity:

**Edit → Preferences → External Tools**

Set:

```text
External Script Editor = JetBrains Rider
```

Under **Generate .csproj files for**, enable:

```text
✓ Embedded packages
✓ Local packages
✓ Registry packages
✓ Git packages
✓ Built-in packages
✓ Player projects
```

Click **Regenerate project files**.

---

## Open the Project in Rider

Recommended method:

1. Open the project in Unity.
2. Double-click any `.cs` file.

Unity will automatically open Rider with the correct solution.

**Important:** Do not open the `Assets` folder directly in Rider.

---

## Verify Rider Integration

Open a script containing:

```csharp
using UnityEngine;

public class Test : MonoBehaviour
{
}
```

Verify that:

- Ctrl + Click on `MonoBehaviour` works.
- Ctrl + Click on `GameObject` works.
- Ctrl + Click on `Transform` works.

If navigation does not work:

1. Close Rider.
2. In Unity, go to **Edit → Preferences → External Tools**.
3. Click **Regenerate project files**.
4. Reopen Rider from Unity.

---

## Rider Plugins

In Rider:

**File → Settings → Plugins**

Ensure the following plugin is enabled:

```text
Unity Support
```

Restart Rider if prompted.

---

## Git Ignore Rules

The following files and folders should NOT be committed:

```gitignore
Library/
Temp/
Logs/
Obj/
.idea/
.vscode/

*.sln
*.slnx
*.csproj
```

These files are generated automatically by Unity and Rider.

---

## Files That Must Be Committed

Always commit:

```text
Assets/
Packages/
ProjectSettings/
.gitignore
```

These contain the actual game source code and project configuration.

---

## First-Time Setup Checklist

- [ ] Install Unity Hub
- [ ] Install the required Unity version
- [ ] Install JetBrains Rider
- [ ] Activate the free Rider license
- [ ] Clone the repository
- [ ] Open the project in Unity Hub
- [ ] Configure Rider as the External Script Editor
- [ ] Regenerate project files
- [ ] Open a script from Unity
- [ ] Verify Ctrl + Click works on Unity classes

You are now ready to develop and run the game.
