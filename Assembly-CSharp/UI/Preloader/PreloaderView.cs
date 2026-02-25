using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.ProgressBars;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace UI.Preloader
{
	// Token: 0x020001D1 RID: 465
	[Token(Token = "0x20001D1")]
	public class PreloaderView : MonoBehaviour
	{
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000195")]
		public PreloaderView.PreloaderInfo Info
		{
			[Token(Token = "0x6000C2E")]
			[Address(RVA = "0x5F3D", Offset = "0x5F3D", VA = "0x5F3D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C2F")]
			[Address(RVA = "0x5F3E", Offset = "0x5F3E", VA = "0x5F3E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x5F3F", Offset = "0x5F3F", VA = "0x5F3F")]
		private void Awake()
		{
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x5F40", Offset = "0x5F40", VA = "0x5F40")]
		private void OnEnable()
		{
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x5F41", Offset = "0x5F41", VA = "0x5F41")]
		private void OnDisable()
		{
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x5F42", Offset = "0x5F42", VA = "0x5F42")]
		private void DisplayTextProgress(float progress)
		{
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x5F43", Offset = "0x5F43", VA = "0x5F43")]
		private IEnumerator ChangeTitleRoutine(TextMeshProUGUI title)
		{
			return null;
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x5F44", Offset = "0x5F44", VA = "0x5F44")]
		private void SetProgress(float value)
		{
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x5F45", Offset = "0x5F45", VA = "0x5F45")]
		public void SetProgress(float current, float total)
		{
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x5F46", Offset = "0x5F46", VA = "0x5F46")]
		public void SetInfo(PreloaderView.PreloaderInfo info)
		{
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x5F47", Offset = "0x5F47", VA = "0x5F47")]
		public void SetOverrideBackground(Sprite sprite)
		{
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x5F48", Offset = "0x5F48", VA = "0x5F48")]
		public void SetBackgroundColor(Color value)
		{
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x5F49", Offset = "0x5F49", VA = "0x5F49")]
		public PreloaderView()
		{
		}

		// Token: 0x040005D4 RID: 1492
		[Token(Token = "0x40005D4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _titleTextField;

		// Token: 0x040005D5 RID: 1493
		[Token(Token = "0x40005D5")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _infoTextField;

		// Token: 0x040005D6 RID: 1494
		[Token(Token = "0x40005D6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _helpButtonLabel;

		// Token: 0x040005D7 RID: 1495
		[Token(Token = "0x40005D7")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _progressLabel;

		// Token: 0x040005D8 RID: 1496
		[Token(Token = "0x40005D8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ProgressBarWithText _progressBar;

		// Token: 0x040005D9 RID: 1497
		[Token(Token = "0x40005D9")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private PreloaderView.LocaleKeys _titles;

		// Token: 0x040005DA RID: 1498
		[Token(Token = "0x40005DA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _titleChangePeriod;

		// Token: 0x040005DB RID: 1499
		[Token(Token = "0x40005DB")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _progressTweenDuration;

		// Token: 0x040005DC RID: 1500
		[Token(Token = "0x40005DC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _background;

		// Token: 0x040005DD RID: 1501
		[Token(Token = "0x40005DD")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Image _paintableBackgound;

		// Token: 0x040005DE RID: 1502
		[Token(Token = "0x40005DE")]
		[FieldOffset(Offset = "0x38")]
		private float _progress;

		// Token: 0x040005DF RID: 1503
		[Token(Token = "0x40005DF")]
		[FieldOffset(Offset = "0x3C")]
		private Tweener _progressTween;

		// Token: 0x020001D2 RID: 466
		[Token(Token = "0x20001D2")]
		public class PreloaderInfo
		{
			// Token: 0x17000196 RID: 406
			// (get) Token: 0x06000C3B RID: 3131 RVA: 0x00003E10 File Offset: 0x00002010
			// (set) Token: 0x06000C3C RID: 3132 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000196")]
			public ulong UserId
			{
				[Token(Token = "0x6000C3B")]
				[Address(RVA = "0x5F4A", Offset = "0x5F4A", VA = "0x5F4A")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
				[Token(Token = "0x6000C3C")]
				[Address(RVA = "0x5F4B", Offset = "0x5F4B", VA = "0x5F4B")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06000C3D RID: 3133 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C3D")]
			[Address(RVA = "0x5F4C", Offset = "0x5F4C", VA = "0x5F4C")]
			public PreloaderInfo(AppBuildInfo appBuildInfo, string separator)
			{
			}

			// Token: 0x06000C3E RID: 3134 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C3E")]
			[Address(RVA = "0x5F4D", Offset = "0x5F4D", VA = "0x5F4D", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x040005E2 RID: 1506
			[Token(Token = "0x40005E2")]
			[FieldOffset(Offset = "0x10")]
			private readonly AppBuildInfo _appBuildInfo;

			// Token: 0x040005E3 RID: 1507
			[Token(Token = "0x40005E3")]
			[FieldOffset(Offset = "0x14")]
			private readonly string _separator;
		}

		// Token: 0x020001D3 RID: 467
		[Token(Token = "0x20001D3")]
		[Serializable]
		public class LocaleKeys
		{
			// Token: 0x06000C3F RID: 3135 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C3F")]
			[Address(RVA = "0x5F4E", Offset = "0x5F4E", VA = "0x5F4E")]
			public string GetText(string language)
			{
				return null;
			}

			// Token: 0x06000C40 RID: 3136 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C40")]
			[Address(RVA = "0x5F4F", Offset = "0x5F4F", VA = "0x5F4F")]
			public LocaleKeys()
			{
			}

			// Token: 0x040005E4 RID: 1508
			[Token(Token = "0x40005E4")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private string _localeKey;

			// Token: 0x040005E5 RID: 1509
			[Token(Token = "0x40005E5")]
			[FieldOffset(Offset = "0xC")]
			private string _language;

			// Token: 0x040005E6 RID: 1510
			[Token(Token = "0x40005E6")]
			[FieldOffset(Offset = "0x10")]
			private readonly List<string> _rows;
		}
	}
}
