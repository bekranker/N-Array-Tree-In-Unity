# ItemHandler - Tree Structure Project

This project contains a system that allows elements to be organized in a hierarchical structure. The `ItemHandler` class manages the elements and their sub-elements by placing them in a tree structure. The project uses recursive functions to work with data structures associated with sub-elements.

## Table of Contents

- [Project Description](#project-description)
- [Usage](#usage)
- [File Structure](#file-structure)
- [Contributing](#contributing)
- [License](#license)
- [NOTE](#note)

## Project Description

This project uses a hierarchical tree structure (`Tree` and `TreeNode`) to manage elements and their sub-elements. Each element (`Item`) represents a category (e.g., weapons, shields), and these elements can have their own sub-elements (`SubItems`). These sub-elements are also added to the tree structure. The `ItemHandler` class manages these elements and constructs the trees.

### Key Components:

1. **Item**: Represents categories (e.g., weapons, shields).
2. **Tree**: Represents the tree structure and contains the root node for each element.
3. **TreeNode**: Represents each node in the tree, including the data (item) and its sub-elements.
4. **ItemHandler**: Manages the elements and organizes them in tree structures.

### Functions:

- **CreateNArrayTree()**: Creates a tree structure for each element and adds sub-elements.
- **AddChildRecursiveFunction()**: Adds sub-elements to the tree (recursive).
- **PrintTreeButtonFunction()**: Prints the tree structure for debugging.

## Usage

To use this project, follow these steps:

1. **Download the project files**: Clone the GitHub repository or download it as a zip file.

   ```bash
   git clone https://github.com/username/ItemHandler.git
   ```

## **NOTE**

This project was made for the AI in Game Quiz.
