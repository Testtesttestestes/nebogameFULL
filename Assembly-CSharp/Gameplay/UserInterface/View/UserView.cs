using System;
using AssetContent;
using AssetContent.Loaders;
using Core.Data;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Tutorial.Guide.Model.Data;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.UserInterface.View
{
	// Token: 0x020003C6 RID: 966
	[Token(Token = "0x20003C6")]
	public class UserView : MonoBehaviour, IToolTipDataProvider, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x0600169D RID: 5789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600169D")]
		[Address(RVA = "0x685E", Offset = "0x685E", VA = "0x685E")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600169E")]
		[Address(RVA = "0x685F", Offset = "0x685F", VA = "0x685F")]
		private void OnEnable()
		{
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600169F")]
		[Address(RVA = "0x6860", Offset = "0x6860", VA = "0x6860")]
		private void OnDisable()
		{
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A0")]
		[Address(RVA = "0x6861", Offset = "0x6861", VA = "0x6861")]
		private void StartListenEvents(UserData user)
		{
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A1")]
		[Address(RVA = "0x6862", Offset = "0x6862", VA = "0x6862")]
		private void StopListenEvents(UserData user)
		{
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060016A2 RID: 5794 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003D4")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x60016A2")]
			[Address(RVA = "0x6863", Offset = "0x6863", VA = "0x6863")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060016A3 RID: 5795 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060016A4 RID: 5796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D5")]
		public UserData UserData
		{
			[Token(Token = "0x60016A3")]
			[Address(RVA = "0x6864", Offset = "0x6864", VA = "0x6864")]
			get
			{
				return null;
			}
			[Token(Token = "0x60016A4")]
			[Address(RVA = "0x6865", Offset = "0x6865", VA = "0x6865")]
			set
			{
			}
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A5")]
		[Address(RVA = "0x6866", Offset = "0x6866", VA = "0x6866")]
		private void HandleUserChanged(UserData fromUser, UserData toUser)
		{
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A6")]
		[Address(RVA = "0x6867", Offset = "0x6867", VA = "0x6867")]
		private void HandleOnUserAprChangedEvent(AprDicWrapper apr)
		{
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A7")]
		[Address(RVA = "0x6868", Offset = "0x6868", VA = "0x6868")]
		public void SetApr(AprDicWrapper apr)
		{
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A8")]
		[Address(RVA = "0x6869", Offset = "0x6869", VA = "0x6869")]
		private void DrawRibbon(AprDicWrapper apr)
		{
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A9")]
		[Address(RVA = "0x686A", Offset = "0x686A", VA = "0x686A", Slot = "5")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60016AA")]
		[Address(RVA = "0x686B", Offset = "0x686B", VA = "0x686B", Slot = "4")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016AB")]
		[Address(RVA = "0x686C", Offset = "0x686C", VA = "0x686C")]
		public UserView()
		{
		}

		// Token: 0x04000BF1 RID: 3057
		[Token(Token = "0x4000BF1")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAssetViewRawImage _avatar;

		// Token: 0x04000BF2 RID: 3058
		[Token(Token = "0x4000BF2")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameRawImageLoader _ribbon;

		// Token: 0x04000BF3 RID: 3059
		[Token(Token = "0x4000BF3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UserNickCultLevelExpView _userInfoBar;

		// Token: 0x04000BF4 RID: 3060
		[Token(Token = "0x4000BF4")]
		[FieldOffset(Offset = "0x1C")]
		private UserData _userData;

		// Token: 0x04000BF5 RID: 3061
		[Token(Token = "0x4000BF5")]
		[FieldOffset(Offset = "0x20")]
		private IGuideTarget _guideTarget;
	}
}
