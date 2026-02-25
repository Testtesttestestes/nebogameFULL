using System;
using Core.Data.Skills;
using Gameplay.Clans.Buildings.Golem.Events;
using Gameplay.Clans.Buildings.Golem.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.Clans.Buildings.Golem.Controller
{
	// Token: 0x02000ADC RID: 2780
	[Token(Token = "0x2000ADC")]
	public class GolemController : AbstractController<GolemModel, GolemEvents>
	{
		// Token: 0x060042F2 RID: 17138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F2")]
		[Address(RVA = "0x91A6", Offset = "0x91A6", VA = "0x91A6")]
		public GolemController(GolemModel model, GolemEvents events)
		{
		}

		// Token: 0x060042F3 RID: 17139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F3")]
		[Address(RVA = "0x91A7", Offset = "0x91A7", VA = "0x91A7")]
		public void GetGolemInfo()
		{
		}

		// Token: 0x060042F4 RID: 17140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F4")]
		[Address(RVA = "0x91A8", Offset = "0x91A8", VA = "0x91A8")]
		public void GetGolemSkills()
		{
		}

		// Token: 0x060042F5 RID: 17141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F5")]
		[Address(RVA = "0x91A9", Offset = "0x91A9", VA = "0x91A9")]
		private void GetUserSkillsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060042F6 RID: 17142 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60042F6")]
		[Address(RVA = "0x91AA", Offset = "0x91AA", VA = "0x91AA")]
		private SkillCollection ConstructSkills(OpToken<IMessage, object> op)
		{
			return null;
		}

		// Token: 0x060042F7 RID: 17143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F7")]
		[Address(RVA = "0x91AB", Offset = "0x91AB", VA = "0x91AB")]
		private void RequestUserArtifacts()
		{
		}

		// Token: 0x060042F8 RID: 17144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F8")]
		[Address(RVA = "0x91AC", Offset = "0x91AC", VA = "0x91AC")]
		private void HandleGetUserArtifactsService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060042F9 RID: 17145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F9")]
		[Address(RVA = "0x91AD", Offset = "0x91AD", VA = "0x91AD", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x040024F5 RID: 9461
		[Token(Token = "0x40024F5")]
		[FieldOffset(Offset = "0x18")]
		private MainService _mainService;
	}
}
