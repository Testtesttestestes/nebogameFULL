using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using Utils;

namespace Gameplay.Combat.View
{
	// Token: 0x02000915 RID: 2325
	[Token(Token = "0x2000915")]
	public class CombatEventsToast : MonoBehaviour
	{
		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x060036C5 RID: 14021 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000ACE")]
		public TextMeshProUGUI TextField
		{
			[Token(Token = "0x60036C5")]
			[Address(RVA = "0x86B4", Offset = "0x86B4", VA = "0x86B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C6")]
		[Address(RVA = "0x86B5", Offset = "0x86B5", VA = "0x86B5")]
		private void Awake()
		{
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C7")]
		[Address(RVA = "0x86B6", Offset = "0x86B6", VA = "0x86B6")]
		public void Show()
		{
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C8")]
		[Address(RVA = "0x86B7", Offset = "0x86B7", VA = "0x86B7")]
		public void Hide()
		{
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x060036C9 RID: 14025 RVA: 0x0000AFE0 File Offset: 0x000091E0
		// (set) Token: 0x060036CA RID: 14026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ACF")]
		public float Duration
		{
			[Token(Token = "0x60036C9")]
			[Address(RVA = "0x86B8", Offset = "0x86B8", VA = "0x86B8")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60036CA")]
			[Address(RVA = "0x86B9", Offset = "0x86B9", VA = "0x86B9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036CB")]
		[Address(RVA = "0x86BA", Offset = "0x86BA", VA = "0x86BA")]
		public void Play()
		{
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036CC")]
		[Address(RVA = "0x86BB", Offset = "0x86BB", VA = "0x86BB")]
		private void OnDestroy()
		{
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036CD")]
		[Address(RVA = "0x86BC", Offset = "0x86BC", VA = "0x86BC")]
		public CombatEventsToast()
		{
		}

		// Token: 0x04001DF7 RID: 7671
		[Token(Token = "0x4001DF7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _textField;

		// Token: 0x04001DF8 RID: 7672
		[Token(Token = "0x4001DF8")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04001DF9 RID: 7673
		[Token(Token = "0x4001DF9")]
		[FieldOffset(Offset = "0x18")]
		private Vector3 _offset;

		// Token: 0x04001DFA RID: 7674
		[Token(Token = "0x4001DFA")]
		[FieldOffset(Offset = "0x24")]
		private TweenContainer _tweenContainer;
	}
}
