using System;
using Gameplay.Inventory.Events;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.ArtifactComparer.Controller
{
	// Token: 0x02000CEC RID: 3308
	[Token(Token = "0x2000CEC")]
	public class ArtifactComparerEvents : AbstractMVCEvents
	{
		// Token: 0x0600507A RID: 20602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600507A")]
		[Address(RVA = "0x9E89", Offset = "0x9E89", VA = "0x9E89")]
		public ArtifactComparerEvents(InventoryBaseEvents inventoryEvents)
		{
		}

		// Token: 0x04002C00 RID: 11264
		[Token(Token = "0x4002C00")]
		[FieldOffset(Offset = "0x14")]
		public readonly InventoryBaseEvents InventoryEvents;

		// Token: 0x04002C01 RID: 11265
		[Token(Token = "0x4002C01")]
		[FieldOffset(Offset = "0x18")]
		public Action TargetArtifactChangedEvent;

		// Token: 0x04002C02 RID: 11266
		[Token(Token = "0x4002C02")]
		[FieldOffset(Offset = "0x1C")]
		public Action InventoryChangedEvent;

		// Token: 0x04002C03 RID: 11267
		[Token(Token = "0x4002C03")]
		[FieldOffset(Offset = "0x20")]
		public Action SelectedSkillsChangedEvent;

		// Token: 0x04002C04 RID: 11268
		[Token(Token = "0x4002C04")]
		[FieldOffset(Offset = "0x24")]
		public Action PowersChangedEvent;
	}
}
