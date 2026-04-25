# CardGenerator

Simple WinForms tool for generating custom ship/player cards using GDI+.

## Features
- Multiple styles (Standard, Holographic, Command)
- Auto-fill ship + player data
- Custom ship image support
- Dynamic stat/text rendering
- Export to PNG

## Usage
1. Select player, ship, and style
2. Edit stats if needed
3. Click **Apply**
4. Click **Save**


## Requirements
- .NET (WinForms)
- `System.Drawing`

## Notes
- `Output` and `Assets` folders must exist
- Avoid invalid filename characters (`\ / : * ? " < > |`)
- GDI+ errors usually mean bad paths or file issues

## Contributing
PRs are welcome but not really necessary as V2 is on the way.
