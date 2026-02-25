using System;
using AssetContent;
using Core.Data;
using Core.Dict.DictWrappers.Wrappers;
using Il2CppDummyDll;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Rating.View
{
	// Token: 0x02000589 RID: 1417
	[Token(Token = "0x2000589")]
	public class UserView : MonoBehaviour, IToolTipDataProvider, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x060021CA RID: 8650 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060021CB RID: 8651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000635")]
		public UserData UserData
		{
			[Token(Token = "0x60021CA")]
			[Address(RVA = "0x7329", Offset = "0x7329", VA = "0x7329")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021CB")]
			[Address(RVA = "0x732A", Offset = "0x732A", VA = "0x732A")]
			set
			{
			}
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021CC")]
		[Address(RVA = "0x732B", Offset = "0x732B", VA = "0x732B")]
		private void HandleUserChanged(UserData fromUser, UserData toUser)
		{
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021CD")]
		[Address(RVA = "0x732C", Offset = "0x732C", VA = "0x732C")]
		private void HandleOnUserAprChangedEvent(AprDicWrapper apr)
		{
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021CE")]
		[Address(RVA = "0x732D", Offset = "0x732D", VA = "0x732D")]
		public void SetApr(AprDicWrapper apr)
		{
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021CF")]
		[Address(RVA = "0x732E", Offset = "0x732E", VA = "0x732E", Slot = "5")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D0")]
		[Address(RVA = "0x732F", Offset = "0x732F", VA = "0x732F")]
		public void ShowContextMenu()
		{
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021D1")]
		[Address(RVA = "0x7330", Offset = "0x7330", VA = "0x7330", Slot = "4")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D2")]
		[Address(RVA = "0x7331", Offset = "0x7331", VA = "0x7331")]
		public UserView()
		{
		}

		// Token: 0x04001294 RID: 4756
		[Token(Token = "0x4001294")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAssetViewRawImage _avatar;

		// Token: 0x04001295 RID: 4757
		[Token(Token = "0x4001295")]
		[FieldOffset(Offset = "0x14")]
		private UserData _userData;
	}
}
