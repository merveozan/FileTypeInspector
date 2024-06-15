
# FileType Inspector

## Overview
This console application uses the `MimeDetective` library to inspect files and determine their MIME type based on their content rather than their extension. This tool is particularly useful for identifying files that have been mislabeled or have misleading extensions.

## Prerequisites
- .NET Core SDK
- MimeDetective package

## Installation
1. Clone this repository or download the source code.
2. Navigate to the project directory.
3. Install the `MimeDetective` package via NuGet:
   ```
   dotnet add package MimeDetective
   ```

## Usage
To run the application:
1. Open your command line interface.
2. Navigate to the directory containing the compiled application.
3. Run the application:
   ```
   dotnet run
   ```
4. When prompted, enter the full path to the file you wish to inspect.

## Supported MIME Types
The application uses MimeDetective's comprehensive library, which supports a wide array of file types including but not limited to:
- Images (e.g., `image/jpeg`, `image/png`)
- Documents (e.g., `application/pdf`, `application/msword`)
- Audio (e.g., `audio/mpeg`, `audio/ogg`)
- Video (e.g., `video/mp4`, `video/quicktime`)
- Text files (e.g., `text/plain`, `text/html`)

## Functionality
The program prompts the user to enter a file path, verifies if the file exists, and then reads the file to determine its MIME type. It outputs the MIME type or a message if the MIME type cannot be determined.

## Error Handling
The application includes basic error handling for common scenarios such as missing file path, file not found, and errors during file reading.

