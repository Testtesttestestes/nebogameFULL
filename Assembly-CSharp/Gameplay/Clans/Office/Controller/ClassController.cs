using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A75 RID: 2677
	[Token(Token = "0x2000A75")]
	public class ClassController : AbstractController<ClassModel, ClassEvents>
	{
		// Token: 0x06003FAF RID: 16303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FAF")]
		[Address(RVA = "0x8E69", Offset = "0x8E69", VA = "0x8E69")]
		public ClassController(ClassModel model, ClassEvents events)
		{
		}

		// Token: 0x06003FB0 RID: 16304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB0")]
		[Address(RVA = "0x8E6A", Offset = "0x8E6A", VA = "0x8E6A", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06003FB1 RID: 16305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB1")]
		[Address(RVA = "0x8E6B", Offset = "0x8E6B", VA = "0x8E6B", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06003FB2 RID: 16306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB2")]
		[Address(RVA = "0x8E6C", Offset = "0x8E6C", VA = "0x8E6C")]
		private void DollItemsChangedEventHandler(ProtoStackableChangesAns msg)
		{
		}

		// Token: 0x06003FB3 RID: 16307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB3")]
		[Address(RVA = "0x8E6D", Offset = "0x8E6D", VA = "0x8E6D")]
		public void GetDollSlots(ulong dollId)
		{
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB4")]
		[Address(RVA = "0x8E6E", Offset = "0x8E6E", VA = "0x8E6E")]
		private void GetDollSlotsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003FB5 RID: 16309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB5")]
		[Address(RVA = "0x8E6F", Offset = "0x8E6F", VA = "0x8E6F")]
		public void GetDollSkills(ulong dollId)
		{
		}

		// Token: 0x06003FB6 RID: 16310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB6")]
		[Address(RVA = "0x8E70", Offset = "0x8E70", VA = "0x8E70")]
		private void GetDollSkillsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB7")]
		[Address(RVA = "0x8E71", Offset = "0x8E71", VA = "0x8E71")]
		public void GetDollSpells(ulong dollId)
		{
		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB8")]
		[Address(RVA = "0x8E72", Offset = "0x8E72", VA = "0x8E72")]
		private void GetDollSpellsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x040023B3 RID: 9139
		[Token(Token = "0x40023B3")]
		[FieldOffset(Offset = "0x18")]
		private ColossusService _service;
	}
}
