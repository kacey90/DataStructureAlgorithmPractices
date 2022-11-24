namespace Algorithms.Other;

/// <summary>
/// https://leetcode.com/problems/detect-squares/description/
/// </summary>
public class DetectSquares 
{
    private readonly Dictionary<int, Dictionary<int, int>> _points = new();
    public DetectSquares() 
    {
    }
    public void Add(int[] point) 
    {
        if (!_points.ContainsKey(point[0]))
        {
            _points.Add(point[0], new Dictionary<int, int>());
        }
        if (!_points[point[0]].ContainsKey(point[1]))
        {
            _points[point[0]].Add(point[1], 0);
        }
        _points[point[0]][point[1]]++;
    }
    public int Count(int[] point) 
    {
        var result = 0;
        var x = point[0];
        var y = point[1];
        foreach (var (x1, y1) in _points.Keys.SelectMany(x1 => _points[x1].Keys.Select(y1 => (x1, y1))))
        {
            if (x1 == x || y1 == y)
            {
                continue;
            }
            if (Math.Abs(x1 - x) == Math.Abs(y1 - y))
            {
                result += _points[x][y1] * _points[x1][y];
            }
        }
        return result;
    }
}
