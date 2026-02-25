using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.ArtifactComparer.View
{
	// Token: 0x02000CD4 RID: 3284
	[Token(Token = "0x2000CD4")]
	public class ArtifactComparerPowerBars : MonoBehaviour
	{
		// Token: 0x06004FF0 RID: 20464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF0")]
		[Address(RVA = "0x9E04", Offset = "0x9E04", VA = "0x9E04")]
		public void SetData(ArtifactData targetArtifact, ArtifactData comparableArtifact, bool showDebugInfo)
		{
		}

		// Token: 0x06004FF1 RID: 20465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF1")]
		[Address(RVA = "0x9E05", Offset = "0x9E05", VA = "0x9E05")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004FF2 RID: 20466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF2")]
		[Address(RVA = "0x9E06", Offset = "0x9E06", VA = "0x9E06")]
		public ArtifactComparerPowerBars()
		{
		}

		// Token: 0x06004FF3 RID: 20467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF3")]
		[Address(RVA = "0x9E07", Offset = "0x9E07", VA = "0x9E07")]
		[CompilerGenerated]
		private void <SetData>g__SetBarValue|13_0(Image bar, float percent, ref ArtifactComparerPowerBars.<>c__DisplayClass13_0 A_3)
		{
		}

		// Token: 0x06004FF4 RID: 20468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF4")]
		[Address(RVA = "0x9E08", Offset = "0x9E08", VA = "0x9E08")]
		[CompilerGenerated]
		private void <SetData>g__SetTitle|13_1(TextMeshProUGUI label, ArtifactData artifact, ref ArtifactComparerPowerBars.<>c__DisplayClass13_0 A_3)
		{
		}

		// Token: 0x04002B7F RID: 11135
		[Token(Token = "0x4002B7F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _barLeft;

		// Token: 0x04002B80 RID: 11136
		[Token(Token = "0x4002B80")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _barRight;

		// Token: 0x04002B81 RID: 11137
		[Token(Token = "0x4002B81")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _leftIcon;

		// Token: 0x04002B82 RID: 11138
		[Token(Token = "0x4002B82")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _rightIcon;

		// Token: 0x04002B83 RID: 11139
		[Token(Token = "0x4002B83")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _leftTitle;

		// Token: 0x04002B84 RID: 11140
		[Token(Token = "0x4002B84")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _rightTitle;

		// Token: 0x04002B85 RID: 11141
		[Token(Token = "0x4002B85")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _barGreenSprite;

		// Token: 0x04002B86 RID: 11142
		[Token(Token = "0x4002B86")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Sprite _barRedSprite;

		// Token: 0x04002B87 RID: 11143
		[Token(Token = "0x4002B87")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _greaterIconSprite;

		// Token: 0x04002B88 RID: 11144
		[Token(Token = "0x4002B88")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Sprite _lessIconSprite;

		// Token: 0x04002B89 RID: 11145
		[Token(Token = "0x4002B89")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _equalsIconSprite;

		// Token: 0x04002B8A RID: 11146
		[Token(Token = "0x4002B8A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int _minBarSize;

		// Token: 0x04002B8B RID: 11147
		[Token(Token = "0x4002B8B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int _maxBarSize;
	}
}
