using System;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.ArtifactComparer.View.Rows
{
	// Token: 0x02000CE1 RID: 3297
	[Token(Token = "0x2000CE1")]
	public class ArtifactComparerRowViewInfo : ArtifactComparerRowView
	{
		// Token: 0x0600504A RID: 20554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600504A")]
		[Address(RVA = "0x9E5B", Offset = "0x9E5B", VA = "0x9E5B", Slot = "4")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x0600504B RID: 20555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600504B")]
		[Address(RVA = "0x9E5C", Offset = "0x9E5C", VA = "0x9E5C")]
		public ArtifactComparerRowViewInfo()
		{
		}

		// Token: 0x04002BDB RID: 11227
		[Token(Token = "0x4002BDB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002BDC RID: 11228
		[Token(Token = "0x4002BDC")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LoaderValueRowView _valueRow1;

		// Token: 0x04002BDD RID: 11229
		[Token(Token = "0x4002BDD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _valueRow1Title;

		// Token: 0x04002BDE RID: 11230
		[Token(Token = "0x4002BDE")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private LoaderValueRowView _valueRow2;

		// Token: 0x04002BDF RID: 11231
		[Token(Token = "0x4002BDF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _valueRow2Title;
	}
}
