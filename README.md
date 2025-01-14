# ItemHandler - Tree Structure Project 🌳

This project implements a hierarchical tree structure to manage items and their sub-items using recursive functions in Unity. The `ItemHandler` class handles the creation of trees, adds sub-items to the tree nodes, and performs various operations on the tree structure. This project is maded for lesson of Artificial inteligence in the game.

## Table of Contents 📚

- [Project Description](#project-description-)
- [Usage](#usage-)
- [Functions](#functions-)
- [NOTE](#note-)

## Project Description 📝

This project uses a tree structure (`Tree` and `TreeNode`) to manage items and their sub-items. Each item (e.g., weapons, shields) can have sub-items (e.g., specific weapons or shield types) which are added recursively to form a complete hierarchy.

### Key Components 🔑:

1. **Item**: Represents categories (e.g., weapons, shields) 🛡️⚔️.
2. **Tree**: Represents the tree structure 🌳 and contains the root node for each element.
3. **TreeNode**: Represents each node in the tree, including the data (item) and its sub-elements 🌲.
4. **ItemHandler**: Manages the elements and organizes them in tree structures ⚙️.

### Functions 🔧:

#### **CreateNArrayTree()** 🌱

- This function loops through the root items (e.g., Weapons, Shields) and creates a tree for each category.
- If a category has no sub-items, it logs a message and skips that category.
- If sub-items are present, it calls `AddChildRecursiveFunction` to add them to the tree recursively.

#### **AddChildRecursiveFunction()** 🔁

- This function recursively adds sub-items to the current tree node.
- It continues to call itself until no more sub-items are found, ensuring the entire hierarchy is built.
- It stops and returns when there are no more children for a particular node.

#### **PrintTreeButtonFunction()** 🖨️

- This function iterates through all created trees and prints the tree structure for debugging purposes using `PrintAllTree`.

#### **CheckItemCanBuyable()** 💰

- This function checks if an item is purchasable by verifying if its parent has been "sold".
- If the parent is sold (`Sold == true`), the item is available for purchase.
- It returns a boolean value to indicate whether the item can be bought.

#### **PrintAllTree()** 📜

- This is a recursive function that prints the entire tree structure from any given start node.
- It prints the connection between parent and child nodes by recursively traversing the tree.

## **NOTE** 📝

The project uses a recursive approach to handle hierarchical data. Initially, the root nodes are defined and assigned, and then the sub-items are recursively added to their corresponding parent nodes.

### Unity Test

You can test the functionality in Unity. Each item in `_Items` is treated as a root. For example, **Weapons**, **Shields**, and **Costumes** are each defined as `Scriptable Objects`, and each of them serves as a root in the tree structure.

## Usage ⚡

To use this project, follow these steps:

1. **Download the project files**: Clone the GitHub repository or download it as a zip file 📥.

   ```bash
   git clone https://github.com/username/ItemHandler.git
   ```
