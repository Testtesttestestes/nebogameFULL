using System;
using System.Collections;
using AssetContent.Loaders;
using Core.Animations;
using Core.Dict.DictWrappers.Wrappers;
using Core.Materials;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Isles.User.View.Monster
{
	// Token: 0x02000D25 RID: 3365
	[Token(Token = "0x2000D25")]
	public class MonsterOnIsleAvatarAnimation : MonoBehaviour, IAlpha
	{
		// Token: 0x06005245 RID: 21061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005245")]
		[Address(RVA = "0xA01C", Offset = "0xA01C", VA = "0xA01C")]
		private void OnEnable()
		{
		}

		// Token: 0x06005246 RID: 21062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005246")]
		[Address(RVA = "0xA01D", Offset = "0xA01D", VA = "0xA01D")]
		private void Start()
		{
		}

		// Token: 0x06005247 RID: 21063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005247")]
		[Address(RVA = "0xA01E", Offset = "0xA01E", VA = "0xA01E")]
		private void Validate()
		{
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x06005248 RID: 21064 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010BE")]
		public GameSpineAnimation[] Animations
		{
			[Token(Token = "0x6005248")]
			[Address(RVA = "0xA01F", Offset = "0xA01F", VA = "0xA01F")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005249 RID: 21065 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005249")]
		[Address(RVA = "0xA020", Offset = "0xA020", VA = "0xA020")]
		private IEnumerator ShowAvatarImage(AprDicWrapper data)
		{
			return null;
		}

		// Token: 0x0600524A RID: 21066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600524A")]
		[Address(RVA = "0xA021", Offset = "0xA021", VA = "0xA021")]
		private void HideAvatarImage()
		{
		}

		// Token: 0x0600524B RID: 21067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600524B")]
		[Address(RVA = "0xA022", Offset = "0xA022", VA = "0xA022")]
		private void ShowAwait()
		{
		}

		// Token: 0x0600524C RID: 21068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600524C")]
		[Address(RVA = "0xA023", Offset = "0xA023", VA = "0xA023")]
		private void ShowAvatar(AprDicWrapper data)
		{
		}

		// Token: 0x0600524D RID: 21069 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600524D")]
		[Address(RVA = "0xA024", Offset = "0xA024", VA = "0xA024")]
		private IEnumerator ShowAvatarRoutine(AprDicWrapper data)
		{
			return null;
		}

		// Token: 0x0600524E RID: 21070 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600524E")]
		[Address(RVA = "0xA025", Offset = "0xA025", VA = "0xA025")]
		private IEnumerator AnimateShowAvatar()
		{
			return null;
		}

		// Token: 0x0600524F RID: 21071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600524F")]
		[Address(RVA = "0xA026", Offset = "0xA026", VA = "0xA026")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x06005250 RID: 21072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005250")]
		[Address(RVA = "0xA027", Offset = "0xA027", VA = "0xA027", Slot = "4")]
		public void SetAlpha(float value)
		{
		}

		// Token: 0x06005251 RID: 21073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005251")]
		[Address(RVA = "0xA028", Offset = "0xA028", VA = "0xA028")]
		public void SetApr(AprDicWrapper value)
		{
		}

		// Token: 0x06005252 RID: 21074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005252")]
		[Address(RVA = "0xA029", Offset = "0xA029", VA = "0xA029")]
		public MonsterOnIsleAvatarAnimation()
		{
		}

		// Token: 0x04002CC1 RID: 11457
		[Token(Token = "0x4002CC1")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SpriteRenderer _cloudPlatform;

		// Token: 0x04002CC2 RID: 11458
		[Token(Token = "0x4002CC2")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameSpineAnimation _avatarTopLayerAnimation;

		// Token: 0x04002CC3 RID: 11459
		[Token(Token = "0x4002CC3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameSpineAnimation _animation;

		// Token: 0x04002CC4 RID: 11460
		[Token(Token = "0x4002CC4")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameSpriteRendererLoader _avatar;

		// Token: 0x04002CC5 RID: 11461
		[Token(Token = "0x4002CC5")]
		[FieldOffset(Offset = "0x20")]
		private AprDicWrapper _aprData;

		// Token: 0x04002CC6 RID: 11462
		[Token(Token = "0x4002CC6")]
		[FieldOffset(Offset = "0x24")]
		private int _startCallCount;

		// Token: 0x04002CC7 RID: 11463
		[Token(Token = "0x4002CC7")]
		[FieldOffset(Offset = "0x28")]
		private GameSpineAnimation[] _animations;

		// Token: 0x04002CC8 RID: 11464
		[Token(Token = "0x4002CC8")]
		[FieldOffset(Offset = "0x2C")]
		private Coroutine _showAvatarCoroutine;

		// Token: 0x02000D26 RID: 3366
		[Token(Token = "0x2000D26")]
		public enum PortalAnimationStates
		{
			// Token: 0x04002CCA RID: 11466
			[Token(Token = "0x4002CCA")]
			unknown,
			// Token: 0x04002CCB RID: 11467
			[Token(Token = "0x4002CCB")]
			idle,
			// Token: 0x04002CCC RID: 11468
			[Token(Token = "0x4002CCC")]
			splash,
			// Token: 0x04002CCD RID: 11469
			[Token(Token = "0x4002CCD")]
			splash_portal_release,
			// Token: 0x04002CCE RID: 11470
			[Token(Token = "0x4002CCE")]
			splash_portal_idle
		}

		// Token: 0x02000D27 RID: 3367
		[Token(Token = "0x2000D27")]
		public enum ToplayerPortalAnimationStates
		{
			// Token: 0x04002CD0 RID: 11472
			[Token(Token = "0x4002CD0")]
			unknown,
			// Token: 0x04002CD1 RID: 11473
			[Token(Token = "0x4002CD1")]
			top_portal_idle,
			// Token: 0x04002CD2 RID: 11474
			[Token(Token = "0x4002CD2")]
			top_portal_release
		}
	}
}
