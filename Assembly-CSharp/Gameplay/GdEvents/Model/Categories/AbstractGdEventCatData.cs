using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.GameTime;
using Il2CppDummyDll;

namespace Gameplay.GdEvents.Model.Categories
{
	// Token: 0x0200075D RID: 1885
	[Token(Token = "0x200075D")]
	public abstract class AbstractGdEventCatData : IDisposable
	{
		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06002CE8 RID: 11496 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008A8")]
		public IList<GdEventData> Items
		{
			[Token(Token = "0x6002CE8")]
			[Address(RVA = "0x7D6C", Offset = "0x7D6C", VA = "0x7D6C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06002CE9 RID: 11497 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CEA RID: 11498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A9")]
		public ITimeOffsetProvider TimeOffsetProvider
		{
			[Token(Token = "0x6002CE9")]
			[Address(RVA = "0x7D6D", Offset = "0x7D6D", VA = "0x7D6D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CEA")]
			[Address(RVA = "0x7D6E", Offset = "0x7D6E", VA = "0x7D6E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06002CEB RID: 11499 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008AA")]
		public TimerStrings TimerStrings
		{
			[Token(Token = "0x6002CEB")]
			[Address(RVA = "0x7D6F", Offset = "0x7D6F", VA = "0x7D6F")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CEC")]
		[Address(RVA = "0x7D70", Offset = "0x7D70", VA = "0x7D70", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CED")]
		[Address(RVA = "0x7D71", Offset = "0x7D71", VA = "0x7D71")]
		public AbstractGdEventCatData(string title, ICurrentTimeProvider timeProvider, ITimeOffsetProvider timeOffsetProvider, TimerStrings timerStrings)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_Model_Categories_AbstractGdEventCatData___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a2ec == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_GdEventData__TypeInfo);
		    DAT_ram_00a5a2ec = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_GdEventData__TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		        goto code_r0x811fa204;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                System_Collections_Generic_ICollection_GdEventData__TypeInfo,3);
		code_r0x811fa204:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CEE")]
		[Address(RVA = "0x7D72", Offset = "0x7D72", VA = "0x7D72")]
		public void ResetItems()
		{
		/* --- GHIDRA: ResetItems ---
		uint Gameplay_GdEvents_Model_Categories_AbstractGdEventCatData__ResetItems
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  float param2_00;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a5a2ed == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_GdEventData__TypeInfo);
		    DAT_ram_00a5a2ed = '\x01';
		  }
		  piVar4 = *(int **)(param2 + 0x14);
		  if (param1 != piVar4) {
		    *(int **)(param2 + 0x14) = param1;
		    uVar1 = 0;
		    param1_00 = *(undefined4 *)(param2 + 0xc);
		    param2_00 = (float)(**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		                                 (param1,param2,*(undefined4 *)(*param1 + 0xfc));
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		    param1_01 = (int *)param1[3];
		    iVar3 = *param1_01;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_ICollection_GdEventData__TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		          goto code_r0x811fa2e1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_01,
		                                  System_Collections_Generic_ICollection_GdEventData__TypeInfo,2);
		code_r0x811fa2e1:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_01,param2,puVar2[1]);
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x118) * 4))
		              (param1,*(undefined4 *)(*param1 + 0x11c));
		  }
		  return (uint)(param1 != piVar4);
		}
		*/

		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x00008A00 File Offset: 0x00006C00
		[Token(Token = "0x6002CEF")]
		[Address(RVA = "0x7D73", Offset = "0x7D73", VA = "0x7D73", Slot = "5")]
		public virtual bool TryAdd(GdEventData evt)
		{
		/* --- GHIDRA: TryAdd ---
		int Gameplay_GdEvents_Model_Categories_AbstractGdEventCatData__TryAdd
		              (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a2ee == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_GdEventData__TypeInfo);
		    DAT_ram_00a5a2ee = '\x01';
		  }
		  param1_00 = (int *)param1[3];
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_GdEventData__TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xf0);
		        goto code_r0x811fa3a6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                System_Collections_Generic_ICollection_GdEventData__TypeInfo,6);
		code_r0x811fa3a6:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  if (iVar3 != 0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(*(undefined4 *)(param2 + 0xc),0.0,0);
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x118) * 4))
		              (param1,*(undefined4 *)(*param1 + 0x11c));
		  }
		  return iVar3;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x00008A18 File Offset: 0x00006C18
		[Token(Token = "0x6002CF0")]
		[Address(RVA = "0x7D74", Offset = "0x7D74", VA = "0x7D74")]
		public bool TryRemove(GdEventData evt)
		{
			return default(bool);
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06002CF1 RID: 11505
		[Token(Token = "0x170008AB")]
		public abstract Category Category { [Token(Token = "0x6002CF1")] get; }

		// Token: 0x06002CF2 RID: 11506
		[Token(Token = "0x6002CF2")]
		public abstract float GetBackTime(GdEventData evt);

		// Token: 0x06002CF3 RID: 11507
		[Token(Token = "0x6002CF3")]
		public abstract string GetBackTimeTitle(GdEventData evt, TimerStrings timerStrings);

		// Token: 0x06002CF4 RID: 11508
		[Token(Token = "0x6002CF4")]
		public abstract bool IsBackTimeAvail(GdEventData evt);

		// Token: 0x06002CF5 RID: 11509
		[Token(Token = "0x6002CF5")]
		public abstract bool IsFit(GdEventData evt);

		// Token: 0x06002CF6 RID: 11510
		[Token(Token = "0x6002CF6")]
		protected abstract void Sort();

		// Token: 0x040018B2 RID: 6322
		[Token(Token = "0x40018B2")]
		[FieldOffset(Offset = "0x8")]
		public readonly string Title;

		// Token: 0x040018B5 RID: 6325
		[Token(Token = "0x40018B5")]
		[FieldOffset(Offset = "0x14")]
		protected ICurrentTimeProvider _timeProvider;

		// Token: 0x040018B6 RID: 6326
		[Token(Token = "0x40018B6")]
		[FieldOffset(Offset = "0x18")]
		protected TimerStrings _timerStrings;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_TimerStrings ---
		void Gameplay_GdEvents_Model_Categories_AbstractGdEventCatData__get_TimerStrings
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a2ec == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_GdEventData__TypeInfo);
		    DAT_ram_00a5a2ec = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_GdEventData__TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		        goto code_r0x811fa14f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                System_Collections_Generic_ICollection_GdEventData__TypeInfo,3);
		code_r0x811fa14f:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  return;
		}
		*/

}
