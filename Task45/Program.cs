int[] CopyArrayStandartTool(int[] inputArray)
{
    int[] buferArray=new int[inputArray.Length];
    inputArray.CopyTo(buferArray,0);
    return buferArray;
}

object[] CopyArrayStandartToolObj(params object[] inputArray)
{
    object[] buferArray=new object[inputArray.Length];
    inputArray.CopyTo(buferArray,0);
    return buferArray;
}
