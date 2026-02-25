using System;
using System.Collections.Generic;
using Core.Data;
using Cysharp.Threading.Tasks;
using Gameplay.Chat.Model;
using Gameplay.Gifts.Controller;
using Gameplay.Gifts.Events;
using Gameplay.Gifts.GdEvents.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.Gifts.GdEvents.Control
{
	// Token: 0x02000714 RID: 1812
	[Token(Token = "0x2000714")]
	public class GiftController : GiftsController
	{
		// Token: 0x06002B5C RID: 11100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B5C")]
		[Address(RVA = "0x7BF6", Offset = "0x7BF6", VA = "0x7BF6", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B5D")]
		[Address(RVA = "0x7BF7", Offset = "0x7BF7", VA = "0x7BF7")]
		public GiftController(IFavoriteUsersProvider favoriteUsersProvider, GiftModel model, GiftsEvents events)
		{
		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x00008718 File Offset: 0x00006918
		[Token(Token = "0x6002B5E")]
		[Address(RVA = "0x217F", Offset = "0x217F", VA = "0x217F")]
		public UniTask<IList<UserData>> GetTargetUsers(int limit)
		{
			return default(UniTask<IList<UserData>>);
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x00008730 File Offset: 0x00006930
		[Token(Token = "0x6002B5F")]
		[Address(RVA = "0x217A", Offset = "0x217A", VA = "0x217A")]
		public UniTask<IList<UserData>> GetClanMembers()
		{
			return default(UniTask<IList<UserData>>);
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B60")]
		[Address(RVA = "0x7BF8", Offset = "0x7BF8", VA = "0x7BF8")]
		private void HandleGetMembersListFaultService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B61")]
		[Address(RVA = "0x7BF9", Offset = "0x7BF9", VA = "0x7BF9")]
		private void HandleGetMembersListService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x040017C3 RID: 6083
		[Token(Token = "0x40017C3")]
		[FieldOffset(Offset = "0x1C")]
		private IFavoriteUsersProvider _favoriteUsersProvider;
	}
}
