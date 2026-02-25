using System;
using System.Runtime.CompilerServices;
using AssetContent;
using CloudsFly;
using Gameplay.Isles.User.Controller;
using Il2CppDummyDll;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D0E RID: 3342
	[Token(Token = "0x2000D0E")]
	public class BackClanIsleView : BaseWorldObjectRenderer, IToolTipDataProvider
	{
		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x06005183 RID: 20867 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001082")]
		public ToolTip ToolTip
		{
			[Token(Token = "0x6005183")]
			[Address(RVA = "0x9F5F", Offset = "0x9F5F", VA = "0x9F5F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x06005184 RID: 20868 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001083")]
		public GameAssetViewSpriteRenderer BgSprite
		{
			[Token(Token = "0x6005184")]
			[Address(RVA = "0x9F60", Offset = "0x9F60", VA = "0x9F60")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001EE RID: 494
		// (add) Token: 0x06005185 RID: 20869 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005186 RID: 20870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001EE")]
		public event Action ClickEvent
		{
			[Token(Token = "0x6005185")]
			[Address(RVA = "0x9F61", Offset = "0x9F61", VA = "0x9F61")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005186")]
			[Address(RVA = "0x9F62", Offset = "0x9F62", VA = "0x9F62")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005187 RID: 20871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005187")]
		[Address(RVA = "0x9F63", Offset = "0x9F63", VA = "0x9F63")]
		private void Awake()
		{
		}

		// Token: 0x06005188 RID: 20872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005188")]
		[Address(RVA = "0x9F64", Offset = "0x9F64", VA = "0x9F64")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005189 RID: 20873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005189")]
		[Address(RVA = "0x9F65", Offset = "0x9F65", VA = "0x9F65")]
		private void BgOnClickEvent(GameAssetViewSpriteRenderer gameAssetViewSpriteRenderer)
		{
		}

		// Token: 0x0600518A RID: 20874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600518A")]
		[Address(RVA = "0x9F66", Offset = "0x9F66", VA = "0x9F66")]
		public void Init(UserIsle isle)
		{
		}

		// Token: 0x0600518B RID: 20875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600518B")]
		[Address(RVA = "0x9F67", Offset = "0x9F67", VA = "0x9F67")]
		public void Deinit()
		{
		}

		// Token: 0x0600518C RID: 20876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600518C")]
		[Address(RVA = "0x9F68", Offset = "0x9F68", VA = "0x9F68", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		}

		// Token: 0x0600518D RID: 20877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600518D")]
		[Address(RVA = "0x9F69", Offset = "0x9F69", VA = "0x9F69", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		}

		// Token: 0x0600518E RID: 20878 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600518E")]
		[Address(RVA = "0x9F6A", Offset = "0x9F6A", VA = "0x9F6A", Slot = "10")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x0600518F RID: 20879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600518F")]
		[Address(RVA = "0x9F6B", Offset = "0x9F6B", VA = "0x9F6B")]
		public BackClanIsleView()
		{
		}

		// Token: 0x04002C57 RID: 11351
		[Token(Token = "0x4002C57")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameAssetViewSpriteRenderer _bgSprite;

		// Token: 0x04002C58 RID: 11352
		[Token(Token = "0x4002C58")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ToolTip _toolTip;

		// Token: 0x04002C59 RID: 11353
		[Token(Token = "0x4002C59")]
		[FieldOffset(Offset = "0x2C")]
		private BackClanIsleViewMediator _mediator;
	}
}
