using System;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Auchan.View
{
	// Token: 0x02000C88 RID: 3208
	[Token(Token = "0x2000C88")]
	public class AuchanArtifactCellGroupViewHolder : CellGroupViewsHolder<AuchanArtifactCellViewHolder>
	{
		// Token: 0x06004E3B RID: 20027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3B")]
		[Address(RVA = "0x9C6E", Offset = "0x9C6E", VA = "0x9C6E", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x06004E3C RID: 20028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3C")]
		[Address(RVA = "0x9C6F", Offset = "0x9C6F", VA = "0x9C6F")]
		public void ShowHeader(string text)
		{
		}

		// Token: 0x06004E3D RID: 20029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3D")]
		[Address(RVA = "0x9C70", Offset = "0x9C70", VA = "0x9C70")]
		public void ClearHeader()
		{
		}

		// Token: 0x06004E3E RID: 20030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3E")]
		[Address(RVA = "0x9C71", Offset = "0x9C71", VA = "0x9C71")]
		public AuchanArtifactCellGroupViewHolder()
		{
		}

		// Token: 0x04002ABA RID: 10938
		[Token(Token = "0x4002ABA")]
		[FieldOffset(Offset = "0x24")]
		private ContentSizeFitter _contentSizeFitterComponent;

		// Token: 0x04002ABB RID: 10939
		[Token(Token = "0x4002ABB")]
		[FieldOffset(Offset = "0x28")]
		private Transform _headerGroup;

		// Token: 0x04002ABC RID: 10940
		[Token(Token = "0x4002ABC")]
		[FieldOffset(Offset = "0x2C")]
		private TextMeshProUGUI _headerLabel;
	}
}
