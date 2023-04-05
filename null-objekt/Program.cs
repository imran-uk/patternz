// See https://aka.ms/new-console-template for more information

// https://en.wikipedia.org/wiki/Null_object_pattern

using null_objekt;

// use the Node class here
var rootNode = new Node();
rootNode.LeftNode = new LeafNode();
rootNode.RightNode = new LeafNode();

// how to set more nodes?
var rightNode = rootNode.RightNode;

Console.WriteLine($"Hello, World! {rootNode.treeSize(rootNode)}");
