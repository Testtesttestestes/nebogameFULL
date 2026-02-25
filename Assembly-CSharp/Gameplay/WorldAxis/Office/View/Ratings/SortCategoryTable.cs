using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x02000301 RID: 769
	[Token(Token = "0x2000301")]
	public class SortCategoryTable : MonoBehaviour
	{
		// Token: 0x0600120A RID: 4618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600120A")]
		[Address(RVA = "0x6405", Offset = "0x6405", VA = "0x6405")]
		public void Init(IEnumerable<SortCategoryListElement.SortCategoryListElementArgs> args)
		{
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600120B")]
		[Address(RVA = "0x6406", Offset = "0x6406", VA = "0x6406")]
		public SortCategoryTable()
		{
		}

		// Token: 0x04000975 RID: 2421
		[Token(Token = "0x4000975")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04000976 RID: 2422
		[Token(Token = "0x4000976")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private SortCategoryListElement _listElementPrefab;
	}
}
