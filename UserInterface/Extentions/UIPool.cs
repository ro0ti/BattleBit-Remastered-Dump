using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using touching_your_mom;
using UnityEngine;

namespace UserInterface.Extentions
{
	// Token: 0x020007CA RID: 1994
	[Token(Token = "0x20007CA")]
	public class UIPool<T> where T : MonoBehaviour
	{
		// Token: 0x06013DC0 RID: 81344 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DC0")]
		public UIPool(GameObject prefab, Transform parent, int allocated = 0, bool usePrefabRotationAndScale = false, bool useCanvasGroup = false)
		{
		}

		// Token: 0x06013DC1 RID: 81345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DC1")]
		public void Allocate(int count)
		{
		}

		// Token: 0x06013DC2 RID: 81346 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013DC2")]
		public T Dequeue([Optional] Vector3 localPosition)
		{
			return null;
		}

		// Token: 0x06013DC3 RID: 81347 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DC3")]
		public void Enqueue(T obj)
		{
		}

		// Token: 0x06013DC4 RID: 81348 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DC4")]
		public void Enqueue(GameObject obj)
		{
		}

		// Token: 0x04003D12 RID: 15634
		[Token(Token = "0x4003D12")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		private GameObject prefab;

		// Token: 0x04003D13 RID: 15635
		[Token(Token = "0x4003D13")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		private Transform parent;

		// Token: 0x04003D14 RID: 15636
		[Token(Token = "0x4003D14")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public bool useCanvasGroup;

		// Token: 0x04003D15 RID: 15637
		[Token(Token = "0x4003D15")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public bool setLastSibling;

		// Token: 0x04003D16 RID: 15638
		[Token(Token = "0x4003D16")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public bool usePrefabTransform;

		// Token: 0x04003D17 RID: 15639
		[Token(Token = "0x4003D17")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public Queue<GameObject> roolList;
	}
}
