using System;
using System.Runtime.CompilerServices;
using AssetContent;
using CloudsFly;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D0F RID: 3343
	[Token(Token = "0x2000D0F")]
	public class BaseIsleMonsterView : BaseWorldObjectRenderer, IDisposable
	{
		// Token: 0x140001EF RID: 495
		// (add) Token: 0x06005190 RID: 20880 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005191 RID: 20881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001EF")]
		public event Action ClickEvent
		{
			[Token(Token = "0x6005190")]
			[Address(RVA = "0x9F6C", Offset = "0x9F6C", VA = "0x9F6C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005191")]
			[Address(RVA = "0x9F6D", Offset = "0x9F6D", VA = "0x9F6D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001084 RID: 4228
		// (set) Token: 0x06005192 RID: 20882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001084")]
		public string AssetId
		{
			[Token(Token = "0x6005192")]
			[Address(RVA = "0x9F6E", Offset = "0x9F6E", VA = "0x9F6E")]
			set
			{
			}
		}

		// Token: 0x06005193 RID: 20883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005193")]
		[Address(RVA = "0x9F6F", Offset = "0x9F6F", VA = "0x9F6F")]
		private void Start()
		{
		}

		// Token: 0x06005194 RID: 20884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005194")]
		[Address(RVA = "0x9F70", Offset = "0x9F70", VA = "0x9F70")]
		private void GameAssetViewOnClickedEvent(GameAssetViewSpriteRenderer obj)
		{
		}

		// Token: 0x06005195 RID: 20885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005195")]
		[Address(RVA = "0x9F71", Offset = "0x9F71", VA = "0x9F71", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		}

		// Token: 0x06005196 RID: 20886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005196")]
		[Address(RVA = "0x9F72", Offset = "0x9F72", VA = "0x9F72", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		}

		// Token: 0x06005197 RID: 20887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005197")]
		[Address(RVA = "0x9F73", Offset = "0x9F73", VA = "0x9F73", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x06005198 RID: 20888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005198")]
		[Address(RVA = "0x9F74", Offset = "0x9F74", VA = "0x9F74", Slot = "11")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06005199 RID: 20889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005199")]
		[Address(RVA = "0x9F75", Offset = "0x9F75", VA = "0x9F75")]
		public BaseIsleMonsterView()
		{
		}

		// Token: 0x04002C5B RID: 11355
		[Token(Token = "0x4002C5B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected GameAssetViewSpriteRenderer _gameAssetView;
	}
}
