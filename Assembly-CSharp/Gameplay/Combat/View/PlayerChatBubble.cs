using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using TMPro;
using UI.Utils;
using UnityEngine;

namespace Gameplay.Combat.View
{
	// Token: 0x02000922 RID: 2338
	[Token(Token = "0x2000922")]
	public class PlayerChatBubble : MonoBehaviour
	{
		// Token: 0x06003717 RID: 14103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003717")]
		[Address(RVA = "0x8706", Offset = "0x8706", VA = "0x8706")]
		private void OnDestroy()
		{
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06003718 RID: 14104 RVA: 0x0000B070 File Offset: 0x00009270
		// (set) Token: 0x06003719 RID: 14105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE2")]
		public bool Visible
		{
			[Token(Token = "0x6003718")]
			[Address(RVA = "0x8707", Offset = "0x8707", VA = "0x8707")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003719")]
			[Address(RVA = "0x8708", Offset = "0x8708", VA = "0x8708")]
			set
			{
			}
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371A")]
		[Address(RVA = "0x8709", Offset = "0x8709", VA = "0x8709")]
		private void HandleVisibleChaged()
		{
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371B")]
		[Address(RVA = "0x870A", Offset = "0x870A", VA = "0x870A")]
		public void AddText(string text)
		{
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371C")]
		[Address(RVA = "0x870B", Offset = "0x870B", VA = "0x870B")]
		public void Stop()
		{
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x0000B088 File Offset: 0x00009288
		[Token(Token = "0x600371D")]
		[Address(RVA = "0x870C", Offset = "0x870C", VA = "0x870C")]
		private bool TryStopTween()
		{
			return default(bool);
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371E")]
		[Address(RVA = "0x870D", Offset = "0x870D", VA = "0x870D")]
		private void Play()
		{
		}

		// Token: 0x0600371F RID: 14111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371F")]
		[Address(RVA = "0x870E", Offset = "0x870E", VA = "0x870E")]
		public PlayerChatBubble()
		{
		}

		// Token: 0x04001E3C RID: 7740
		[Token(Token = "0x4001E3C")]
		public const float DISPLAY_DURATION = 4.5f;

		// Token: 0x04001E3D RID: 7741
		[Token(Token = "0x4001E3D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _textField;

		// Token: 0x04001E3E RID: 7742
		[Token(Token = "0x4001E3E")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private LayoutUpdater _layoutUpdater;

		// Token: 0x04001E3F RID: 7743
		[Token(Token = "0x4001E3F")]
		[FieldOffset(Offset = "0x18")]
		private bool _visible;

		// Token: 0x04001E40 RID: 7744
		[Token(Token = "0x4001E40")]
		[FieldOffset(Offset = "0x1C")]
		private Queue<string> _textQueue;

		// Token: 0x04001E41 RID: 7745
		[Token(Token = "0x4001E41")]
		[FieldOffset(Offset = "0x20")]
		private Tween _delayedTween;

		// Token: 0x04001E42 RID: 7746
		[Token(Token = "0x4001E42")]
		[FieldOffset(Offset = "0x24")]
		private bool _isPlay;
	}
}
