using System;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.ArtifactComparer.View.Rows
{
	// Token: 0x02000CE2 RID: 3298
	[Token(Token = "0x2000CE2")]
	public class ArtifactComparerRowViewSpell : ArtifactComparerRowView
	{
		// Token: 0x0600504C RID: 20556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600504C")]
		[Address(RVA = "0x9E5D", Offset = "0x9E5D", VA = "0x9E5D", Slot = "4")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x0600504D RID: 20557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600504D")]
		[Address(RVA = "0x9E5E", Offset = "0x9E5E", VA = "0x9E5E")]
		public ArtifactComparerRowViewSpell()
		{
		}

		// Token: 0x04002BE0 RID: 11232
		[Token(Token = "0x4002BE0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002BE1 RID: 11233
		[Token(Token = "0x4002BE1")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ModifierRowView _valueRow1;

		// Token: 0x04002BE2 RID: 11234
		[Token(Token = "0x4002BE2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ModifierRowView _valueRow2;
	}
}
