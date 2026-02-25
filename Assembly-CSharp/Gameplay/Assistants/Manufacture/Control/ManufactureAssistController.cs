using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Assistants.Manufacture.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Craft;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Gameplay.Assistants.Manufacture.Control
{
	// Token: 0x02000CB0 RID: 3248
	[Token(Token = "0x2000CB0")]
	public class ManufactureAssistController : AbstractController<ManufactureAssistModel, ManufactureAssistantEvents>
	{
		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x06004F13 RID: 20243 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004F14 RID: 20244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001019")]
		public ServicesService ServicesService
		{
			[Token(Token = "0x6004F13")]
			[Address(RVA = "0x9D3B", Offset = "0x9D3B", VA = "0x9D3B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F14")]
			[Address(RVA = "0x9D3C", Offset = "0x9D3C", VA = "0x9D3C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x06004F15 RID: 20245 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004F16 RID: 20246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700101A")]
		public CraftService CraftService
		{
			[Token(Token = "0x6004F15")]
			[Address(RVA = "0x9D3D", Offset = "0x9D3D", VA = "0x9D3D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F16")]
			[Address(RVA = "0x9D3E", Offset = "0x9D3E", VA = "0x9D3E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004F17 RID: 20247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F17")]
		[Address(RVA = "0x9D3F", Offset = "0x9D3F", VA = "0x9D3F", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06004F18 RID: 20248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F18")]
		[Address(RVA = "0x9D40", Offset = "0x9D40", VA = "0x9D40")]
		public ManufactureAssistController(ManufactureAssistModel model, ManufactureAssistantEvents events)
		{
		}

		// Token: 0x06004F19 RID: 20249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F19")]
		[Address(RVA = "0x9D41", Offset = "0x9D41", VA = "0x9D41", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06004F1A RID: 20250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F1A")]
		[Address(RVA = "0x9D42", Offset = "0x9D42", VA = "0x9D42", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06004F1B RID: 20251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F1B")]
		[Address(RVA = "0x9D43", Offset = "0x9D43", VA = "0x9D43")]
		private void HandleManufactureGetInfo(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004F1C RID: 20252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F1C")]
		[Address(RVA = "0x9D44", Offset = "0x9D44", VA = "0x9D44")]
		private void HandleManufacturePutArtifactService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004F1D RID: 20253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F1D")]
		[Address(RVA = "0x9D45", Offset = "0x9D45", VA = "0x9D45")]
		private void HandleManufactureDismantleProgressEvent(ProtoManufactureGetInfoAns msg)
		{
		}

		// Token: 0x06004F1E RID: 20254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F1E")]
		[Address(RVA = "0x9D46", Offset = "0x9D46", VA = "0x9D46")]
		private void HandleOnArtifactDropRemoveEvent(DropTypes dropType, ArtifactData artifact)
		{
		}

		// Token: 0x06004F1F RID: 20255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F1F")]
		[Address(RVA = "0x9D47", Offset = "0x9D47", VA = "0x9D47")]
		private void HandleOnDropRemoveEvent(DropTypes dropType)
		{
		}

		// Token: 0x06004F20 RID: 20256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F20")]
		[Address(RVA = "0x9D48", Offset = "0x9D48", VA = "0x9D48")]
		private void HandleManufactureDismantleService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004F21 RID: 20257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F21")]
		[Address(RVA = "0x9D49", Offset = "0x9D49", VA = "0x9D49")]
		private void HandleManufactureTakeArtifact(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004F22 RID: 20258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F22")]
		[Address(RVA = "0x9D4A", Offset = "0x9D4A", VA = "0x9D4A")]
		private void SetStatus(AssistantStatus status)
		{
		}

		// Token: 0x06004F23 RID: 20259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F23")]
		[Address(RVA = "0x9D4B", Offset = "0x9D4B", VA = "0x9D4B")]
		private void SetInfo(ProtoManufactureGetInfoAns msg)
		{
		}

		// Token: 0x06004F24 RID: 20260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F24")]
		[Address(RVA = "0x9D4C", Offset = "0x9D4C", VA = "0x9D4C")]
		private void SetDismantleSlot(ArtifactInfo artifactInfo, int fromSlotId = -1)
		{
		}

		// Token: 0x06004F25 RID: 20261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F25")]
		[Address(RVA = "0x9D4D", Offset = "0x9D4D", VA = "0x9D4D")]
		private void Put(ArtifactData artifact)
		{
		}

		// Token: 0x06004F26 RID: 20262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F26")]
		[Address(RVA = "0x9D4E", Offset = "0x9D4E", VA = "0x9D4E")]
		public void RequestInfo()
		{
		}

		// Token: 0x06004F27 RID: 20263 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		[Token(Token = "0x6004F27")]
		[Address(RVA = "0x9D4F", Offset = "0x9D4F", VA = "0x9D4F")]
		public bool TryPut(ArtifactData artifact)
		{
			return default(bool);
		}

		// Token: 0x06004F28 RID: 20264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F28")]
		[Address(RVA = "0x9D50", Offset = "0x9D50", VA = "0x9D50")]
		public void Take(ArtifactData artifact)
		{
		}

		// Token: 0x06004F29 RID: 20265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F29")]
		[Address(RVA = "0x9D51", Offset = "0x9D51", VA = "0x9D51")]
		public void Dismantle(uint stackSize)
		{
		}

		// Token: 0x06004F2A RID: 20266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F2A")]
		[Address(RVA = "0x9D52", Offset = "0x9D52", VA = "0x9D52")]
		public void TakeAll()
		{
		}

		// Token: 0x06004F2B RID: 20267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F2B")]
		[Address(RVA = "0x9D53", Offset = "0x9D53", VA = "0x9D53")]
		public void SellAll()
		{
		}
	}
}
