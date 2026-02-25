using System;
using AssetContent.Loaders;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.ArtifactComparer.View
{
	// Token: 0x02000CD2 RID: 3282
	[Token(Token = "0x2000CD2")]
	public class ArtifactComparerItemView : AbstractDataRenderer<ArtifactData>
	{
		// Token: 0x06004FE9 RID: 20457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FE9")]
		[Address(RVA = "0x9DFD", Offset = "0x9DFD", VA = "0x9DFD", Slot = "9")]
		protected override void Awake()
		{
		}

		// Token: 0x06004FEA RID: 20458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FEA")]
		[Address(RVA = "0x9DFE", Offset = "0x9DFE", VA = "0x9DFE", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06004FEB RID: 20459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FEB")]
		[Address(RVA = "0x9DFF", Offset = "0x9DFF", VA = "0x9DFF")]
		public ArtifactComparerItemView()
		{
		}

		// Token: 0x04002B79 RID: 11129
		[Token(Token = "0x4002B79")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ArtifactView _artifactView;

		// Token: 0x04002B7A RID: 11130
		[Token(Token = "0x4002B7A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameImageLoader _bgImageLoader;

		// Token: 0x04002B7B RID: 11131
		[Token(Token = "0x4002B7B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _title;
	}
}
