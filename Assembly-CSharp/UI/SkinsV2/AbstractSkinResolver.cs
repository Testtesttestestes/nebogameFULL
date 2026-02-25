using System;
using System.Threading;
using Core.Gameplay.Managers.Skins;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.SkinsV2
{
	// Token: 0x02000180 RID: 384
	[Token(Token = "0x2000180")]
	public abstract class AbstractSkinResolver<TComponent, TContent> : MonoBehaviour where TContent : UnityEngine.Object
	{
		// Token: 0x06000AE0 RID: 2784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE1")]
		private void Awake()
		{
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE2")]
		private void OnEnable()
		{
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE3")]
		private void Start()
		{
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00003A38 File Offset: 0x00001C38
		[Token(Token = "0x6000AE4")]
		private UniTaskVoid Resolve(CancellationToken token)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE5")]
		private void SetSkin(Skin value)
		{
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE6")]
		private void HandleSkinsManagerSkinChangedEvt(SkinManager manager)
		{
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE7")]
		private void HandleStopEvent(Skin skin)
		{
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE8")]
		private void SetupDefaultContentOnce(TComponent component)
		{
		}

		// Token: 0x06000AE9 RID: 2793
		[Token(Token = "0x6000AE9")]
		protected abstract void GetDefaultContent(TComponent component, out AbstractSkinResolver<TComponent, TContent>.ContentInfo content);

		// Token: 0x06000AEA RID: 2794
		[Token(Token = "0x6000AEA")]
		protected abstract void Rollback(TComponent component, TContent content);

		// Token: 0x06000AEB RID: 2795
		[Token(Token = "0x6000AEB")]
		protected abstract UniTask<bool> TryResolve(TComponent component, Skin skin, CancellationToken cancellationToken);

		// Token: 0x06000AEC RID: 2796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AEC")]
		public void Resolve()
		{
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AED")]
		private void StartResolve()
		{
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AEE")]
		private void StartRollback()
		{
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AEF")]
		protected AbstractSkinResolver()
		{
		}

		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x40004D5")]
		[FieldOffset(Offset = "0x0")]
		private readonly CancellationTokenSource _cancellationSource;

		// Token: 0x040004D6 RID: 1238
		[Token(Token = "0x40004D6")]
		[FieldOffset(Offset = "0x0")]
		private AbstractSkinResolver<TComponent, TContent>.ContentInfo _defaultContent;

		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x40004D7")]
		[FieldOffset(Offset = "0x0")]
		private SkinManager _skinsManager;

		// Token: 0x040004D8 RID: 1240
		[Token(Token = "0x40004D8")]
		[FieldOffset(Offset = "0x0")]
		private Skin _skin;

		// Token: 0x02000181 RID: 385
		[Token(Token = "0x2000181")]
		protected sealed class ContentInfo
		{
			// Token: 0x06000AF0 RID: 2800 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000AF0")]
			public ContentInfo(string name, TContent content)
			{
			}

			// Token: 0x040004D9 RID: 1241
			[Token(Token = "0x40004D9")]
			[FieldOffset(Offset = "0x0")]
			public readonly string Name;

			// Token: 0x040004DA RID: 1242
			[Token(Token = "0x40004DA")]
			[FieldOffset(Offset = "0x0")]
			public readonly TContent Content;
		}
	}
}
