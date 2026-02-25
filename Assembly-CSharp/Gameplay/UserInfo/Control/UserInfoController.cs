using System;
using System.Collections.Generic;
using Core.Data;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.UserInfo.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Dic;
using ServicesNamespace;
using Utils;
using Utils.Accumulators;

namespace Gameplay.UserInfo.Control
{
	// Token: 0x0200041B RID: 1051
	[Token(Token = "0x200041B")]
	public class UserInfoController : AbstractController<UserInfoModel, UserInfoEvents>
	{
		// Token: 0x06001895 RID: 6293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001895")]
		[Address(RVA = "0x6A34", Offset = "0x6A34", VA = "0x6A34")]
		public UserInfoController(MainService mainService, ServicesService servicesService, UserInfoModel model, UserInfoEvents events)
		{
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001896")]
		[Address(RVA = "0x6A35", Offset = "0x6A35", VA = "0x6A35", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001897")]
		[Address(RVA = "0x6A36", Offset = "0x6A36", VA = "0x6A36", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001898")]
		[Address(RVA = "0x6A37", Offset = "0x6A37", VA = "0x6A37")]
		private void RequestGetPossibleNicks(string nick)
		{
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001899")]
		[Address(RVA = "0x6A38", Offset = "0x6A38", VA = "0x6A38")]
		private void HandleGetPossibleNicksService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189A")]
		[Address(RVA = "0x6A39", Offset = "0x6A39", VA = "0x6A39")]
		public void RequestNickChangePrice()
		{
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189B")]
		[Address(RVA = "0x6A3A", Offset = "0x6A3A", VA = "0x6A3A")]
		private void RequestChangesNick(string nick, bool check)
		{
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189C")]
		[Address(RVA = "0x6A3B", Offset = "0x6A3B", VA = "0x6A3B")]
		private void RequestChangeApr(uint aprId, bool check)
		{
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189D")]
		[Address(RVA = "0x6A3C", Offset = "0x6A3C", VA = "0x6A3C")]
		private void RequestUserArtifacts(UserData user)
		{
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189E")]
		[Address(RVA = "0x6A3D", Offset = "0x6A3D", VA = "0x6A3D")]
		private void HandleGetUserArtifactsService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189F")]
		[Address(RVA = "0x6A3E", Offset = "0x6A3E", VA = "0x6A3E")]
		private void ValidateUserSkills()
		{
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A0")]
		[Address(RVA = "0x6A3F", Offset = "0x6A3F", VA = "0x6A3F")]
		private void HandleChangeAprService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A1")]
		[Address(RVA = "0x6A40", Offset = "0x6A40", VA = "0x6A40")]
		private void HandleGetNickPriceService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A2")]
		[Address(RVA = "0x6A41", Offset = "0x6A41", VA = "0x6A41")]
		private void HandleChangeNickService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A3")]
		[Address(RVA = "0x6A42", Offset = "0x6A42", VA = "0x6A42")]
		private void SetupPriceOfChangeNick(ResourceSet price)
		{
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A4")]
		[Address(RVA = "0x6A43", Offset = "0x6A43", VA = "0x6A43")]
		private void UserOnUserSkillsChangedEvent()
		{
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A5")]
		[Address(RVA = "0x6A44", Offset = "0x6A44", VA = "0x6A44")]
		private void HandleUserTriggersUpdateEvent(IEnumerable<TriggerValue> changes, AccumulatorBase<int, TriggerValue> accumulator)
		{
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A6")]
		[Address(RVA = "0x6A45", Offset = "0x6A45", VA = "0x6A45")]
		private void ValidateInit()
		{
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A7")]
		[Address(RVA = "0x6A46", Offset = "0x6A46", VA = "0x6A46")]
		private void HandleOnUserNickChangedEvent()
		{
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A8")]
		[Address(RVA = "0x6A47", Offset = "0x6A47", VA = "0x6A47")]
		private void UserOnOnUserAprChangedEvent(AprDicWrapper apr)
		{
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A9")]
		[Address(RVA = "0x6A48", Offset = "0x6A48", VA = "0x6A48")]
		private void HandleEquipChangedEvent()
		{
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AA")]
		[Address(RVA = "0x6A49", Offset = "0x6A49", VA = "0x6A49")]
		private void UserCacheResultCallback(long operationIndex, UserData[] data)
		{
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AB")]
		[Address(RVA = "0x6A4A", Offset = "0x6A4A", VA = "0x6A4A")]
		private void UserBasicCacheResultCallback(long operationIndex, UserData[] data)
		{
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AC")]
		[Address(RVA = "0x6A4B", Offset = "0x6A4B", VA = "0x6A4B")]
		public void ChangeCult(AprDicWrapper apr)
		{
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AD")]
		[Address(RVA = "0x6A4C", Offset = "0x6A4C", VA = "0x6A4C")]
		public void ChangeNick(string nick)
		{
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AE")]
		[Address(RVA = "0x6A4D", Offset = "0x6A4D", VA = "0x6A4D")]
		public void GenerateNick()
		{
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AF")]
		[Address(RVA = "0x6A4E", Offset = "0x6A4E", VA = "0x6A4E")]
		public void SelectApr(GenderDic genderDic, CultDic cultDic)
		{
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B0")]
		[Address(RVA = "0x6A4F", Offset = "0x6A4F", VA = "0x6A4F")]
		public void DeselectSelectedApr()
		{
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B1")]
		[Address(RVA = "0x6A50", Offset = "0x6A50", VA = "0x6A50")]
		public void SetMedalsVisible(bool value)
		{
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B2")]
		[Address(RVA = "0x6A51", Offset = "0x6A51", VA = "0x6A51")]
		public void SetAprsVisible(bool value)
		{
		}

		// Token: 0x04000D27 RID: 3367
		[Token(Token = "0x4000D27")]
		[FieldOffset(Offset = "0x18")]
		private readonly MainService _mainService;

		// Token: 0x04000D28 RID: 3368
		[Token(Token = "0x4000D28")]
		[FieldOffset(Offset = "0x1C")]
		private readonly ServicesService _servicesService;
	}
}
