using System;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.GdEvents.View.EventsList
{
	// Token: 0x02000738 RID: 1848
	[Token(Token = "0x2000738")]
	[Serializable]
	public class MyGridParams : GridParams
	{
		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06002C1A RID: 11290 RVA: 0x00008778 File Offset: 0x00006978
		[Token(Token = "0x17000863")]
		public float HeaderSize
		{
			[Token(Token = "0x6002C1A")]
			[Address(RVA = "0x7CAA", Offset = "0x7CAA", VA = "0x7CAA")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002C1B")]
		[Address(RVA = "0x7CAB", Offset = "0x7CAB", VA = "0x7CAB", Slot = "9")]
		protected override GameObject CreateCellGroupPrefabGameObject()
		{
			return null;
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002C1C")]
		[Address(RVA = "0x7CAC", Offset = "0x7CAC", VA = "0x7CAC", Slot = "10")]
		protected override LayoutGroup AddLayoutGroupToCellGroupPrefab(GameObject cellGroupGameObject)
		{
			return null;
		}

		// Token: 0x06002C1D RID: 11293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C1D")]
		[Address(RVA = "0x7CAD", Offset = "0x7CAD", VA = "0x7CAD")]
		public MyGridParams()
		{
		}

		// Token: 0x04001827 RID: 6183
		[Token(Token = "0x4001827")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _CellGroupPrefab;

		// Token: 0x04001828 RID: 6184
		[Token(Token = "0x4001828")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _HeaderSize;
	}
}
