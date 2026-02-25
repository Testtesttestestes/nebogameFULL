using System;
using Gameplay.UserInterface.Control;
using Gameplay.UserInterface.Events;
using Gameplay.UserInterface.Model;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.UserInterface.View
{
	// Token: 0x020003BE RID: 958
	[Token(Token = "0x20003BE")]
	public class LocationOwnerIndexView : MonoBehaviour
	{
		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001677 RID: 5751 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003BF")]
		public UserIndexView UserIndexView
		{
			[Token(Token = "0x6001677")]
			[Address(RVA = "0x6838", Offset = "0x6838", VA = "0x6838")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003C0")]
		public ClanIndexView ClanIndexView
		{
			[Token(Token = "0x6001678")]
			[Address(RVA = "0x6839", Offset = "0x6839", VA = "0x6839")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001679 RID: 5753 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003C1")]
		public Button RatingButton
		{
			[Token(Token = "0x6001679")]
			[Address(RVA = "0x683A", Offset = "0x683A", VA = "0x683A")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600167A")]
		[Address(RVA = "0x683B", Offset = "0x683B", VA = "0x683B")]
		public void Init(UserInterfaceModel model, UserInterfaceEvents events, UserInterfaceController controller)
		{
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600167B")]
		[Address(RVA = "0x683C", Offset = "0x683C", VA = "0x683C")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600167C")]
		[Address(RVA = "0x683D", Offset = "0x683D", VA = "0x683D")]
		public LocationOwnerIndexView()
		{
		}

		// Token: 0x04000BCF RID: 3023
		[Token(Token = "0x4000BCF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private UserIndexView _userIndexView;

		// Token: 0x04000BD0 RID: 3024
		[Token(Token = "0x4000BD0")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ClanIndexView _clanIndexView;

		// Token: 0x04000BD1 RID: 3025
		[Token(Token = "0x4000BD1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _ratingButton;

		// Token: 0x04000BD2 RID: 3026
		[Token(Token = "0x4000BD2")]
		[FieldOffset(Offset = "0x1C")]
		private LocationOwnerIndexViewMediator _mediator;
	}
}
