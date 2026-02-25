using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Combat.View.Spells
{
	// Token: 0x02000941 RID: 2369
	[Token(Token = "0x2000941")]
	public class CombatElixirButton : CombatSpellButton
	{
		// Token: 0x0600380E RID: 14350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600380E")]
		[Address(RVA = "0x87C5", Offset = "0x87C5", VA = "0x87C5", Slot = "8")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x0600380F RID: 14351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600380F")]
		[Address(RVA = "0x87C6", Offset = "0x87C6", VA = "0x87C6", Slot = "15")]
		public override void UpdateCount()
		{
		}

		// Token: 0x06003810 RID: 14352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003810")]
		[Address(RVA = "0x87C7", Offset = "0x87C7", VA = "0x87C7", Slot = "16")]
		protected override void LoadImage()
		{
		}

		// Token: 0x06003811 RID: 14353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003811")]
		[Address(RVA = "0x87C8", Offset = "0x87C8", VA = "0x87C8", Slot = "14")]
		protected override void HandleEnabledChanged()
		{
		}

		// Token: 0x06003812 RID: 14354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003812")]
		[Address(RVA = "0x87C9", Offset = "0x87C9", VA = "0x87C9")]
		protected new void Start()
		{
		}

		// Token: 0x06003813 RID: 14355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003813")]
		[Address(RVA = "0x87CA", Offset = "0x87CA", VA = "0x87CA")]
		public CombatElixirButton()
		{
		}

		// Token: 0x04001EFF RID: 7935
		[Token(Token = "0x4001EFF")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameRawImage _artifactQualityImage;

		// Token: 0x04001F00 RID: 7936
		[Token(Token = "0x4001F00")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TextMeshProUGUI _countTextField;
	}
}
