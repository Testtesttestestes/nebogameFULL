using System;
using Gameplay.Antiq.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

namespace Gameplay.Antiq.View
{
	// Token: 0x02000D7D RID: 3453
	[Token(Token = "0x2000D7D")]
	[AddComponentMenu("Antiq/View/EffectView")]
	internal class EffectView : MonoBehaviour
	{
		// Token: 0x06005492 RID: 21650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005492")]
		[Address(RVA = "0x1D28", Offset = "0x1D28", VA = "0x1D28")]
		public void SetData(EffectData value, [CanBeNull] EffectData currentValue)
		{
		}

		// Token: 0x06005493 RID: 21651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005493")]
		[Address(RVA = "0x1D2A", Offset = "0x1D2A", VA = "0x1D2A")]
		public void SetIsComplete(bool value)
		{
		}

		// Token: 0x06005494 RID: 21652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005494")]
		[Address(RVA = "0xA243", Offset = "0xA243", VA = "0xA243")]
		public EffectView()
		{
		}

		// Token: 0x04002DBF RID: 11711
		[Token(Token = "0x4002DBF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TMP_Text _currentValue;

		// Token: 0x04002DC0 RID: 11712
		[Token(Token = "0x4002DC0")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TMP_Text _title;

		// Token: 0x04002DC1 RID: 11713
		[Token(Token = "0x4002DC1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TMP_Text _value;

		// Token: 0x04002DC2 RID: 11714
		[Token(Token = "0x4002DC2")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform[] _toHideWhenComplete;
	}
}
