using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.ArtifactComparer.View.Rows
{
	// Token: 0x02000CE3 RID: 3299
	[Token(Token = "0x2000CE3")]
	public class ArtifactComparerRowViewTitle : ArtifactComparerRowView
	{
		// Token: 0x0600504E RID: 20558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600504E")]
		[Address(RVA = "0x9E5F", Offset = "0x9E5F", VA = "0x9E5F", Slot = "4")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x0600504F RID: 20559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600504F")]
		[Address(RVA = "0x9E60", Offset = "0x9E60", VA = "0x9E60")]
		public ArtifactComparerRowViewTitle()
		{
		}

		// Token: 0x04002BE3 RID: 11235
		[Token(Token = "0x4002BE3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002BE4 RID: 11236
		[Token(Token = "0x4002BE4")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Image _separator1;

		// Token: 0x04002BE5 RID: 11237
		[Token(Token = "0x4002BE5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _separator2;
	}
}
