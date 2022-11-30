/*
 * Created by SharpDevelop.
 * User: UMUM
 * Date: 30/11/2022
 * Time: 16:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Halo{
	
public class BinarySearchTree
	{
		public Node Root;
		
		public BinarySearchTree()
		{
			Root = null;
		}
		
		public void Add(int data){
			// buat node baru untuk data yang akan ditambahkan
			Node baru = new Node(data);
			
			// cek apakah tree masih kosong
			if(Root == null){
				Root = baru;
			}else{
				bool inserted = false;
				Node temp = Root;
				while(inserted == false){
					// bandingkan data baru dengan temp
					if(baru.Data < temp.Data){
						// letakkan data baru sebagai left child
						if(temp.LeftChild == null){
							temp.LeftChild = baru;
							baru.Parent = temp;
							inserted = true;
						}else{
							temp = temp.LeftChild;
						}
					}else{
						if(temp.RightChild == null){
							temp.RightChild = baru;
							baru.Parent = temp;
							inserted = true;
						}else{
							temp = temp.RightChild;
						}
					}
				}
			}
		}
	}
}