using System;
using System.Runtime.CompilerServices;
using Core;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace AssetContent.Loaders
{
	// Token: 0x02000E34 RID: 3636
	[Token(Token = "0x2000E34")]
	[RequireComponent(typeof(SpriteRenderer))]
	[DisallowMultipleComponent]
	public class GameSpriteRendererLoader : MonoBehaviour, IAsyncLoadableContent, IGameAssetContent
	{
		// Token: 0x14000218 RID: 536
		// (add) Token: 0x0600590D RID: 22797 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600590E RID: 22798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000218")]
		public event Action<IAsyncLoadableContent> ReadyEvent
		{
			[Token(Token = "0x600590D")]
			[Address(RVA = "0xA661", Offset = "0xA661", VA = "0xA661", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600590E")]
			[Address(RVA = "0xA662", Offset = "0xA662", VA = "0xA662", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x0600590F RID: 22799 RVA: 0x0000FD50 File Offset: 0x0000DF50
		// (set) Token: 0x06005910 RID: 22800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001223")]
		public bool IsReady
		{
			[Token(Token = "0x600590F")]
			[Address(RVA = "0xA663", Offset = "0xA663", VA = "0xA663", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005910")]
			[Address(RVA = "0xA664", Offset = "0xA664", VA = "0xA664")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x06005911 RID: 22801 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001224")]
		private MaterialPropertyBlock MaterialPropertyBlock
		{
			[Token(Token = "0x6005911")]
			[Address(RVA = "0xA665", Offset = "0xA665", VA = "0xA665")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x06005912 RID: 22802 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001225")]
		public SpriteRenderer SpriteRenderer
		{
			[Token(Token = "0x6005912")]
			[Address(RVA = "0x1DFB", Offset = "0x1DFB", VA = "0x1DFB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x06005913 RID: 22803 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005914 RID: 22804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001226")]
		public string AssetId
		{
			[Token(Token = "0x6005913")]
			[Address(RVA = "0xA666", Offset = "0xA666", VA = "0xA666", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005914")]
			[Address(RVA = "0xA667", Offset = "0xA667", VA = "0xA667", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x06005915 RID: 22805 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005916 RID: 22806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001227")]
		public string AssetPath
		{
			[Token(Token = "0x6005915")]
			[Address(RVA = "0xA668", Offset = "0xA668", VA = "0xA668", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005916")]
			[Address(RVA = "0xA669", Offset = "0xA669", VA = "0xA669")]
			set
			{
			}
		}

		// Token: 0x06005917 RID: 22807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005917")]
		[Address(RVA = "0xA66A", Offset = "0xA66A", VA = "0xA66A")]
		private void SetAssetPath(string value)
		{
		}

		// Token: 0x06005918 RID: 22808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005918")]
		[Address(RVA = "0xA66B", Offset = "0xA66B", VA = "0xA66B")]
		private void FailCallback(string resourceUrl)
		{
		}

		// Token: 0x06005919 RID: 22809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005919")]
		[Address(RVA = "0xA66C", Offset = "0xA66C", VA = "0xA66C")]
		private void CompleteCallback(Sprite sprite, string resourceUrl)
		{
		}

		// Token: 0x0600591A RID: 22810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600591A")]
		[Address(RVA = "0xA66D", Offset = "0xA66D", VA = "0xA66D")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600591B RID: 22811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600591B")]
		[Address(RVA = "0xA66E", Offset = "0xA66E", VA = "0xA66E", Slot = "10")]
		protected virtual void HandleSpriteChanged()
		{
		}

		// Token: 0x0600591C RID: 22812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600591C")]
		[Address(RVA = "0xA66F", Offset = "0xA66F", VA = "0xA66F", Slot = "11")]
		public void SetGrayscale(float value)
		{
		}

		// Token: 0x0600591D RID: 22813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600591D")]
		[Address(RVA = "0xA670", Offset = "0xA670", VA = "0xA670")]
		public GameSpriteRendererLoader()
		{
		}

		// Token: 0x04003015 RID: 12309
		[Token(Token = "0x4003015")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _fadeInDuration;

		// Token: 0x04003017 RID: 12311
		[Token(Token = "0x4003017")]
		[FieldOffset(Offset = "0x18")]
		private string _assetId;

		// Token: 0x04003018 RID: 12312
		[Token(Token = "0x4003018")]
		[FieldOffset(Offset = "0x1C")]
		private string _assetPath;

		// Token: 0x04003019 RID: 12313
		[Token(Token = "0x4003019")]
		[FieldOffset(Offset = "0x20")]
		protected bool _isDestroyed;

		// Token: 0x0400301A RID: 12314
		[Token(Token = "0x400301A")]
		[FieldOffset(Offset = "0x24")]
		private Tween _colorTween;

		// Token: 0x0400301B RID: 12315
		[Token(Token = "0x400301B")]
		[FieldOffset(Offset = "0x28")]
		private MaterialPropertyBlock _materialPropertyBlock;

		// Token: 0x0400301C RID: 12316
		[Token(Token = "0x400301C")]
		[FieldOffset(Offset = "0x2C")]
		protected SpriteRenderer _spriteRenderer;
	}
}
