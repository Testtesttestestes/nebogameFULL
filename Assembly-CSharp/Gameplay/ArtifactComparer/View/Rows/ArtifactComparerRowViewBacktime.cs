using System;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.ArtifactComparer.View.Rows
{
	// Token: 0x02000CE0 RID: 3296
	[Token(Token = "0x2000CE0")]
	public class ArtifactComparerRowViewBacktime : ArtifactComparerRowView
	{
		// Token: 0x06005048 RID: 20552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005048")]
		[Address(RVA = "0x9E59", Offset = "0x9E59", VA = "0x9E59", Slot = "4")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06005049 RID: 20553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005049")]
		[Address(RVA = "0x9E5A", Offset = "0x9E5A", VA = "0x9E5A")]
		public ArtifactComparerRowViewBacktime()
		{
		}

		// Token: 0x04002BD6 RID: 11222
		[Token(Token = "0x4002BD6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002BD7 RID: 11223
		[Token(Token = "0x4002BD7")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private BackTimeRowView _valueRow1;

		// Token: 0x04002BD8 RID: 11224
		[Token(Token = "0x4002BD8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _valueRow1Title;

		// Token: 0x04002BD9 RID: 11225
		[Token(Token = "0x4002BD9")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private BackTimeRowView _valueRow2;

		// Token: 0x04002BDA RID: 11226
		[Token(Token = "0x4002BDA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _valueRow2Title;
	}
}
