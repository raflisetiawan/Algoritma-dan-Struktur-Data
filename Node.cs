/*
 * Created by SharpDevelop.
 * User: UMUM
 * Date: 30/11/2022
 * Time: 16:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
namespace Halo{
	

public class Node
	{
	public int Data;
	public Node Parent;
	public Node LeftChild;
	public Node RightChild;
	
	public Node(int data)
	{
		this.Data = data;
	}
}
}