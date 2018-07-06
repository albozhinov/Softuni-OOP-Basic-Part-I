﻿using System;
using System.Collections.Generic;
using System.Text;


class Rectangle
{
    private string id;
    private double width;
    private double height;
    private double topLeftX;
    private double topLeftY;

    public Rectangle(string id, double width, double height, double topLeftX, double topLeftY)
    {
        this.id = id;
        this.width = width;
        this.height = height;
        this.topLeftX = topLeftX;
        this.topLeftY = topLeftY;
    }
    public string ID { get { return this.id; } }

    public bool Intersect(Rectangle rectangle)
    {
       return  rectangle.topLeftX + rectangle.width >= this.topLeftX &&
                rectangle.topLeftX <= this.topLeftX + this.width &&
                rectangle.topLeftY >= this.topLeftY - this.height &&
                rectangle.topLeftY - rectangle.height <= this.topLeftY;
    }
}

