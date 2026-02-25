using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Combat.View.Spells
{
	// Token: 0x02000942 RID: 2370
	[Token(Token = "0x2000942")]
	public class CombatElixirButtonV2 : CombatSpellButton
	{
		// Token: 0x06003814 RID: 14356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003814")]
		[Address(RVA = "0x87CB", Offset = "0x87CB", VA = "0x87CB", Slot = "8")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003815")]
		[Address(RVA = "0x87CC", Offset = "0x87CC", VA = "0x87CC", Slot = "15")]
		public override void UpdateCount()
		{
		}

		// Token: 0x06003816 RID: 14358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003816")]
		[Address(RVA = "0x87CD", Offset = "0x87CD", VA = "0x87CD", Slot = "16")]
		protected override void LoadImage()
		{
		}

		// Token: 0x06003817 RID: 14359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003817")]
		[Address(RVA = "0x87CE", Offset = "0x87CE", VA = "0x87CE", Slot = "14")]
		protected override void HandleEnabledChanged()
		{
		}

		// Token: 0x06003818 RID: 14360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003818")]
		[Address(RVA = "0x87CF", Offset = "0x87CF", VA = "0x87CF")]
		protected new void Start()
		{
		}

		// Token: 0x06003819 RID: 14361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003819")]
		[Address(RVA = "0x87D0", Offset = "0x87D0", VA = "0x87D0")]
		public CombatElixirButtonV2()
		{
		}

		// Token: 0x04001F01 RID: 7937
		[Token(Token = "0x4001F01")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameRawImage _artifactQualityImage;

		// Token: 0x04001F02 RID: 7938
		[Token(Token = "0x4001F02")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TextMeshProUGUI _countTextField;
	}
}
