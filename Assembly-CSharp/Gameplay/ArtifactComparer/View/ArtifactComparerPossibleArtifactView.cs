using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.ArtifactComparer.View
{
	// Token: 0x02000CD3 RID: 3283
	[Token(Token = "0x2000CD3")]
	public class ArtifactComparerPossibleArtifactView : MonoBehaviour
	{
		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x06004FEC RID: 20460 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700102B")]
		public ArtifactView ArtifactView
		{
			[Token(Token = "0x6004FEC")]
			[Address(RVA = "0x9E00", Offset = "0x9E00", VA = "0x9E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x06004FED RID: 20461 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
		// (set) Token: 0x06004FEE RID: 20462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700102C")]
		public bool Selected
		{
			[Token(Token = "0x6004FED")]
			[Address(RVA = "0x9E01", Offset = "0x9E01", VA = "0x9E01")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004FEE")]
			[Address(RVA = "0x9E02", Offset = "0x9E02", VA = "0x9E02")]
			set
			{
			}
		}

		// Token: 0x06004FEF RID: 20463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FEF")]
		[Address(RVA = "0x9E03", Offset = "0x9E03", VA = "0x9E03")]
		public ArtifactComparerPossibleArtifactView()
		{
		}

		// Token: 0x04002B7C RID: 11132
		[Token(Token = "0x4002B7C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _selectionImage;

		// Token: 0x04002B7D RID: 11133
		[Token(Token = "0x4002B7D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ArtifactView _artifactView;

		// Token: 0x04002B7E RID: 11134
		[Token(Token = "0x4002B7E")]
		[FieldOffset(Offset = "0x18")]
		private bool _selected;
	}
}
