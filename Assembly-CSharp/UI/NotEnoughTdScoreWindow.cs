using System;
using System.Runtime.CompilerServices;
using Gameplay.ThemeDuel.Model;
using Il2CppDummyDll;
using UI.Elements.Buttons;
using UI.Windows;
using UnityEngine;

namespace UI
{
	// Token: 0x02000107 RID: 263
	[Token(Token = "0x2000107")]
	public class NotEnoughTdScoreWindow : BaseDialogWindow<NotEnoughTdScoreWindow.NotEnoughTdScoreWindowArgs>
	{
		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00003528 File Offset: 0x00001728
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010F")]
		public bool PlayThemeDuelOnWindowClose
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0x5C21", Offset = "0x5C21", VA = "0x5C21")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000878")]
			[Address(RVA = "0x5C22", Offset = "0x5C22", VA = "0x5C22")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000110")]
		public override string WindowId
		{
			[Token(Token = "0x6000879")]
			[Address(RVA = "0x5C23", Offset = "0x5C23", VA = "0x5C23", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x5C24", Offset = "0x5C24", VA = "0x5C24", Slot = "27")]
		protected override void HandleDescription()
		{
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x5C25", Offset = "0x5C25", VA = "0x5C25", Slot = "22")]
		protected override void OnShow(NotEnoughTdScoreWindow.NotEnoughTdScoreWindowArgs args)
		{
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x5C26", Offset = "0x5C26", VA = "0x5C26")]
		private void Start()
		{
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087D")]
		[Address(RVA = "0x5C27", Offset = "0x5C27", VA = "0x5C27")]
		private void OnInDuel()
		{
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087E")]
		[Address(RVA = "0x5C28", Offset = "0x5C28", VA = "0x5C28", Slot = "29")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087F")]
		[Address(RVA = "0x5C29", Offset = "0x5C29", VA = "0x5C29")]
		public NotEnoughTdScoreWindow()
		{
		}

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ButtonWithCost _inDuelButton;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/NotEnoughTdScoreWindow";

		// Token: 0x02000108 RID: 264
		[Token(Token = "0x2000108")]
		public class NotEnoughTdScoreWindowArgs : BaseDialogWindow<NotEnoughTdScoreWindow.NotEnoughTdScoreWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x17000111 RID: 273
			// (get) Token: 0x06000880 RID: 2176 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000111")]
			public ThemeDuelModel Model
			{
				[Token(Token = "0x6000880")]
				[Address(RVA = "0x5C2A", Offset = "0x5C2A", VA = "0x5C2A")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x06000881 RID: 2177 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000112")]
			public string DescriptionShort
			{
				[Token(Token = "0x6000881")]
				[Address(RVA = "0x5C2B", Offset = "0x5C2B", VA = "0x5C2B")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06000882 RID: 2178 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000882")]
			[Address(RVA = "0x5C2C", Offset = "0x5C2C", VA = "0x5C2C")]
			public NotEnoughTdScoreWindowArgs(ThemeDuelModel model)
			{
			}
		}
	}
}
