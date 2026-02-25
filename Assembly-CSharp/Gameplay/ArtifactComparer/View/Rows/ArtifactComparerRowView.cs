using System;
using Gameplay.ArtifactComparer.Model;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.ArtifactComparer.View.Rows
{
	// Token: 0x02000CDF RID: 3295
	[Token(Token = "0x2000CDF")]
	public class ArtifactComparerRowView : MonoBehaviour
	{
		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x06005041 RID: 20545 RVA: 0x0000EB50 File Offset: 0x0000CD50
		// (set) Token: 0x06005042 RID: 20546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700103E")]
		public uint? Index
		{
			[Token(Token = "0x6005041")]
			[Address(RVA = "0x9E52", Offset = "0x9E52", VA = "0x9E52")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005042")]
			[Address(RVA = "0x9E53", Offset = "0x9E53", VA = "0x9E53")]
			set
			{
			}
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x06005043 RID: 20547 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005044 RID: 20548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700103F")]
		public ArtifactComparerRowData Data
		{
			[Token(Token = "0x6005043")]
			[Address(RVA = "0x9E54", Offset = "0x9E54", VA = "0x9E54")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005044")]
			[Address(RVA = "0x9E55", Offset = "0x9E55", VA = "0x9E55")]
			set
			{
			}
		}

		// Token: 0x06005045 RID: 20549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005045")]
		[Address(RVA = "0x9E56", Offset = "0x9E56", VA = "0x9E56", Slot = "4")]
		protected virtual void HandleDataChanged()
		{
		}

		// Token: 0x06005046 RID: 20550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005046")]
		[Address(RVA = "0x9E57", Offset = "0x9E57", VA = "0x9E57", Slot = "5")]
		protected virtual void HandleIndexChanged()
		{
		}

		// Token: 0x06005047 RID: 20551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005047")]
		[Address(RVA = "0x9E58", Offset = "0x9E58", VA = "0x9E58")]
		public ArtifactComparerRowView()
		{
		}

		// Token: 0x04002BCF RID: 11215
		[Token(Token = "0x4002BCF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _bg1;

		// Token: 0x04002BD0 RID: 11216
		[Token(Token = "0x4002BD0")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _bg2;

		// Token: 0x04002BD1 RID: 11217
		[Token(Token = "0x4002BD1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _bg3;

		// Token: 0x04002BD2 RID: 11218
		[Token(Token = "0x4002BD2")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Sprite _bgDarkSprite;

		// Token: 0x04002BD3 RID: 11219
		[Token(Token = "0x4002BD3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _bgLightSprite;

		// Token: 0x04002BD4 RID: 11220
		[Token(Token = "0x4002BD4")]
		[FieldOffset(Offset = "0x24")]
		private uint? _index;

		// Token: 0x04002BD5 RID: 11221
		[Token(Token = "0x4002BD5")]
		[FieldOffset(Offset = "0x2C")]
		private ArtifactComparerRowData _data;
	}
}
