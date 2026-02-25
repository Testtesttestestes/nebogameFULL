using System;
using Core.Animations;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Test
{
	// Token: 0x02000E43 RID: 3651
	[Token(Token = "0x2000E43")]
	public class AnimationLoaderTest : MonoBehaviour
	{
		// Token: 0x06005980 RID: 22912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005980")]
		[Address(RVA = "0xA6AC", Offset = "0xA6AC", VA = "0xA6AC")]
		public AnimationLoaderTest()
		{
		}

		// Token: 0x06005981 RID: 22913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005981")]
		[Address(RVA = "0xA6AD", Offset = "0xA6AD", VA = "0xA6AD")]
		public void LoadAnimation(string url, Transform worldAnimationsContainer, Transform canvasAnimationsContainer)
		{
		}

		// Token: 0x06005982 RID: 22914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005982")]
		[Address(RVA = "0xA6AE", Offset = "0xA6AE", VA = "0xA6AE")]
		private void FailCallback(string resourceUrl)
		{
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x06005983 RID: 22915 RVA: 0x0000FE28 File Offset: 0x0000E028
		[Token(Token = "0x17001241")]
		private bool IsPan
		{
			[Token(Token = "0x6005983")]
			[Address(RVA = "0xA6AF", Offset = "0xA6AF", VA = "0xA6AF")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005984 RID: 22916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005984")]
		[Address(RVA = "0xA6B0", Offset = "0xA6B0", VA = "0xA6B0")]
		private void CompleteCallback(IGameAnimation iGameAnimation, string resourceUrl)
		{
		}

		// Token: 0x06005985 RID: 22917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005985")]
		[Address(RVA = "0xA6B1", Offset = "0xA6B1", VA = "0xA6B1")]
		private void AdjustCanvasAnimation()
		{
		}

		// Token: 0x06005986 RID: 22918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005986")]
		[Address(RVA = "0xA6B2", Offset = "0xA6B2", VA = "0xA6B2")]
		private void AdjustSceneAnimation()
		{
		}

		// Token: 0x06005987 RID: 22919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005987")]
		[Address(RVA = "0xA6B3", Offset = "0xA6B3", VA = "0xA6B3")]
		private void OnCompleteEvent(IGameAnimation obj)
		{
		}

		// Token: 0x06005988 RID: 22920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005988")]
		[Address(RVA = "0xA6B4", Offset = "0xA6B4", VA = "0xA6B4")]
		public void ShowTestPrefab(GameObject animation)
		{
		}

		// Token: 0x06005989 RID: 22921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005989")]
		[Address(RVA = "0xA6B5", Offset = "0xA6B5", VA = "0xA6B5")]
		private void OnDestroy()
		{
		}

		// Token: 0x04003049 RID: 12361
		[Token(Token = "0x4003049")]
		[FieldOffset(Offset = "0x10")]
		private string _url;

		// Token: 0x0400304A RID: 12362
		[Token(Token = "0x400304A")]
		[FieldOffset(Offset = "0x14")]
		private RawImage _testTextureImage;

		// Token: 0x0400304B RID: 12363
		[Token(Token = "0x400304B")]
		[FieldOffset(Offset = "0x18")]
		private Transform _worldAnimationsContainer;

		// Token: 0x0400304C RID: 12364
		[Token(Token = "0x400304C")]
		[FieldOffset(Offset = "0x1C")]
		private Transform _canvasAnimationsContainer;

		// Token: 0x0400304D RID: 12365
		[Token(Token = "0x400304D")]
		[FieldOffset(Offset = "0x20")]
		private GameObject _animationGameObject;

		// Token: 0x0400304E RID: 12366
		[Token(Token = "0x400304E")]
		[FieldOffset(Offset = "0x24")]
		private readonly Lazy<Camera> _camera;

		// Token: 0x0400304F RID: 12367
		[Token(Token = "0x400304F")]
		[FieldOffset(Offset = "0x28")]
		private readonly Lazy<Text> _debugText;
	}
}
