using System;
using Core.Data;
using Gameplay.Isles.Base;
using Gameplay.Isles.User.Controller;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using Protocol.World;

namespace Gameplay.Isles.User
{
	// Token: 0x02000D0C RID: 3340
	[Token(Token = "0x2000D0C")]
	public class UserIsle : AbstractIsle<UserIsleEvents, UserIsleModel, UserIsleController, UserBuildingTypes>
	{
		// Token: 0x06005179 RID: 20857 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005179")]
		[Address(RVA = "0x9F56", Offset = "0x9F56", VA = "0x9F56", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600517A")]
		[Address(RVA = "0x1CA1", Offset = "0x1CA1", VA = "0x1CA1")]
		public UserIsle(UserData userData, UserData loggedUser, ProtoGetUserIsleInfoAns.Types.IsleInformation isleInformation, int cacheTtl)
		{
		}

		// Token: 0x0600517B RID: 20859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600517B")]
		[Address(RVA = "0x9F57", Offset = "0x9F57", VA = "0x9F57")]
		public UserIsle(UserData userData, UserData loggedUser, int cacheTtl)
		{
		}

		// Token: 0x0600517C RID: 20860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600517C")]
		[Address(RVA = "0x9F58", Offset = "0x9F58", VA = "0x9F58")]
		private void CreateMvc()
		{
		}

		// Token: 0x0600517D RID: 20861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600517D")]
		[Address(RVA = "0x9F59", Offset = "0x9F59", VA = "0x9F59")]
		public void ShowMonsterWindow()
		{
		}

		// Token: 0x0600517E RID: 20862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600517E")]
		[Address(RVA = "0x9F5A", Offset = "0x9F5A", VA = "0x9F5A")]
		public void ShowPortalWindow()
		{
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x0600517F RID: 20863 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
		[Token(Token = "0x17001080")]
		public override LocationTypes LocationType
		{
			[Token(Token = "0x600517F")]
			[Address(RVA = "0x9F5B", Offset = "0x9F5B", VA = "0x9F5B", Slot = "10")]
			get
			{
				return LocationTypes.UnknownLocationType;
			}
		}

		// Token: 0x06005180 RID: 20864 RVA: 0x0000EDD8 File Offset: 0x0000CFD8
		[Token(Token = "0x6005180")]
		[Address(RVA = "0x9F5C", Offset = "0x9F5C", VA = "0x9F5C", Slot = "11")]
		public override bool TryOpenBuildingByType(uint type)
		{
			return default(bool);
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x06005181 RID: 20865 RVA: 0x0000EDF0 File Offset: 0x0000CFF0
		[Token(Token = "0x17001081")]
		public bool IsDeprecated
		{
			[Token(Token = "0x6005181")]
			[Address(RVA = "0x9F5D", Offset = "0x9F5D", VA = "0x9F5D")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04002C54 RID: 11348
		[Token(Token = "0x4002C54")]
		[FieldOffset(Offset = "0x24")]
		private readonly UserData _userData;

		// Token: 0x04002C55 RID: 11349
		[Token(Token = "0x4002C55")]
		[FieldOffset(Offset = "0x28")]
		private readonly UserData _loggedUser;

		// Token: 0x04002C56 RID: 11350
		[Token(Token = "0x4002C56")]
		[FieldOffset(Offset = "0x2C")]
		private int _lifetimeEndTimestamp;
	}
}
