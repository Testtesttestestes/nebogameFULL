using System;
using AssetContent;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View
{
	// Token: 0x0200045A RID: 1114
	[Token(Token = "0x200045A")]
	public class GraphicPointerView : MonoBehaviour
	{
		// Token: 0x06001A70 RID: 6768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A70")]
		[Address(RVA = "0x6C07", Offset = "0x6C07", VA = "0x6C07")]
		public void SetGraphicPointer(string assetId)
		{
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A71")]
		[Address(RVA = "0x6C08", Offset = "0x6C08", VA = "0x6C08")]
		public void SetRotation(float angle)
		{
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A72")]
		[Address(RVA = "0x6C09", Offset = "0x6C09", VA = "0x6C09")]
		public void SetPositionOffset(RectTransform rectTransform, Vector3 offset)
		{
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A73")]
		[Address(RVA = "0x6C0A", Offset = "0x6C0A", VA = "0x6C0A")]
		public void PlayAnimation(GraphicPointerView.Animation animation, bool loop = true)
		{
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A74")]
		[Address(RVA = "0x6C0B", Offset = "0x6C0B", VA = "0x6C0B")]
		public void SetPosition(Vector2 position)
		{
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A75")]
		[Address(RVA = "0x6C0C", Offset = "0x6C0C", VA = "0x6C0C")]
		public void Init(GraphicPointerView.GraphicPointerViewArgs args)
		{
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A76")]
		[Address(RVA = "0x6C0D", Offset = "0x6C0D", VA = "0x6C0D")]
		public GraphicPointerView()
		{
		}

		// Token: 0x04000E42 RID: 3650
		[Token(Token = "0x4000E42")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAnimationView _gameAnimationView;

		// Token: 0x0200045B RID: 1115
		[Token(Token = "0x200045B")]
		public enum Animation
		{
			// Token: 0x04000E44 RID: 3652
			[Token(Token = "0x4000E44")]
			click,
			// Token: 0x04000E45 RID: 3653
			[Token(Token = "0x4000E45")]
			double_click,
			// Token: 0x04000E46 RID: 3654
			[Token(Token = "0x4000E46")]
			long_click,
			// Token: 0x04000E47 RID: 3655
			[Token(Token = "0x4000E47")]
			swipe_down,
			// Token: 0x04000E48 RID: 3656
			[Token(Token = "0x4000E48")]
			swipe_left,
			// Token: 0x04000E49 RID: 3657
			[Token(Token = "0x4000E49")]
			swipe_right,
			// Token: 0x04000E4A RID: 3658
			[Token(Token = "0x4000E4A")]
			swipe_up
		}

		// Token: 0x0200045C RID: 1116
		[Token(Token = "0x200045C")]
		public class GraphicPointerViewArgs
		{
			// Token: 0x06001A77 RID: 6775 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001A77")]
			[Address(RVA = "0x6C0E", Offset = "0x6C0E", VA = "0x6C0E")]
			public GraphicPointerViewArgs()
			{
			}

			// Token: 0x04000E4B RID: 3659
			[Token(Token = "0x4000E4B")]
			[FieldOffset(Offset = "0x8")]
			public GraphicPointerView.Animation Animation;

			// Token: 0x04000E4C RID: 3660
			[Token(Token = "0x4000E4C")]
			[FieldOffset(Offset = "0xC")]
			public Vector2 Position;

			// Token: 0x04000E4D RID: 3661
			[Token(Token = "0x4000E4D")]
			[FieldOffset(Offset = "0x14")]
			public float Angle;
		}
	}
}
