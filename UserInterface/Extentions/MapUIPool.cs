using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using touching_your_mom;
using UnityEngine;

namespace UserInterface.Extentions
{
	// Token: 0x020007CB RID: 1995
	[Token(Token = "0x20007CB")]
	public class MapUIPool<T> where T : MonoBehaviour
	{
		// Token: 0x06013DC5 RID: 81349 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DC5")]
		public MapUIPool(GameObject prefab, Transform parent, int allocated = 0, bool usePrefabRotationAndScale = false)
		{
		}

		// Token: 0x06013DC6 RID: 81350 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DC6")]
		public void Allocate(int count)
		{
		}

		// Token: 0x06013DC7 RID: 81351 RVA: 0x0000270E File Offset: 0x0000090E
		[Token(Token = "0x6013DC7")]
		public T Dequeue([Optional] Vector3 localPosition)
		{
			return null;
		}

		// Token: 0x06013DC8 RID: 81352 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DC8")]
		public void Enqueue(T obj)
		{
		}

		// Token: 0x06013DC9 RID: 81353 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013DC9")]
		public void Enqueue(GameObject obj)
		{
		}

		// Token: 0x04003D18 RID: 15640
		[Token(Token = "0x4003D18")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		private GameObject prefab;

		// Token: 0x04003D19 RID: 15641
		[Token(Token = "0x4003D19")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		private Transform parent;

		// Token: 0x04003D1A RID: 15642
		[Token(Token = "0x4003D1A")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public bool useCanvasGroup;

		// Token: 0x04003D1B RID: 15643
		[Token(Token = "0x4003D1B")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public bool setLastSibling;

		// Token: 0x04003D1C RID: 15644
		[Token(Token = "0x4003D1C")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public bool usePrefabTransform;

		// Token: 0x04003D1D RID: 15645
		[Token(Token = "0x4003D1D")]
		[touching_your_mom.FieldOffset(Offset = "0x0")]
		public Queue<GameObject> roolList;
	}
}
