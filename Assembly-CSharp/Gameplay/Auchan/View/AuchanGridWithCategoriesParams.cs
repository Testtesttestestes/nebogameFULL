using System;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Auchan.View
{
	// Token: 0x02000C87 RID: 3207
	[Token(Token = "0x2000C87")]
	[Serializable]
	public class AuchanGridWithCategoriesParams : GridParams
	{
		// Token: 0x06004E38 RID: 20024 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004E38")]
		[Address(RVA = "0x9C6B", Offset = "0x9C6B", VA = "0x9C6B", Slot = "9")]
		protected override GameObject CreateCellGroupPrefabGameObject()
		{
			return null;
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x06004E39 RID: 20025 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FD7")]
		public Sprite[] MarkerSprites
		{
			[Token(Token = "0x6004E39")]
			[Address(RVA = "0x9C6C", Offset = "0x9C6C", VA = "0x9C6C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004E3A RID: 20026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3A")]
		[Address(RVA = "0x9C6D", Offset = "0x9C6D", VA = "0x9C6D")]
		public AuchanGridWithCategoriesParams()
		{
		}

		// Token: 0x04002AB8 RID: 10936
		[Token(Token = "0x4002AB8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _cellGroupPrefab;

		// Token: 0x04002AB9 RID: 10937
		[Token(Token = "0x4002AB9")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Sprite[] _markersSprites;
	}
}
