using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol;
using Protocol.Auchan;
using UnityEngine;
using Utils;

namespace Gameplay.Auchan.Model
{
	// Token: 0x02000C93 RID: 3219
	[Token(Token = "0x2000C93")]
	public class AuchanArtifactData : IArtifactView
	{
		// Token: 0x140001E3 RID: 483
		// (add) Token: 0x06004E63 RID: 20067 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004E64 RID: 20068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001E3")]
		public event Action DataChangedEvent
		{
			[Token(Token = "0x6004E63")]
			[Address(RVA = "0x9C95", Offset = "0x9C95", VA = "0x9C95", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004E64")]
			[Address(RVA = "0x9C96", Offset = "0x9C96", VA = "0x9C96", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x06004E65 RID: 20069 RVA: 0x0000E598 File Offset: 0x0000C798
		// (set) Token: 0x06004E66 RID: 20070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FDF")]
		public ArtifactView.ArtifactViewArgs Args
		{
			[Token(Token = "0x6004E65")]
			[Address(RVA = "0x9C97", Offset = "0x9C97", VA = "0x9C97", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(ArtifactView.ArtifactViewArgs);
			}
			[Token(Token = "0x6004E66")]
			[Address(RVA = "0x9C98", Offset = "0x9C98", VA = "0x9C98", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x06004E67 RID: 20071 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FE0")]
		public GameObject GameObject
		{
			[Token(Token = "0x6004E67")]
			[Address(RVA = "0x9C99", Offset = "0x9C99", VA = "0x9C99", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x06004E68 RID: 20072 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FE1")]
		public ArtifactData ArtifactData
		{
			[Token(Token = "0x6004E68")]
			[Address(RVA = "0x9C9A", Offset = "0x9C9A", VA = "0x9C9A", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x06004E69 RID: 20073 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FE2")]
		public IActionInfo Info
		{
			[Token(Token = "0x6004E69")]
			[Address(RVA = "0x9C9B", Offset = "0x9C9B", VA = "0x9C9B", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x06004E6A RID: 20074 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FE3")]
		public BackTime Backtime
		{
			[Token(Token = "0x6004E6A")]
			[Address(RVA = "0x9C9C", Offset = "0x9C9C", VA = "0x9C9C", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x06004E6B RID: 20075 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
		[Token(Token = "0x17000FE4")]
		public bool OnlyMarketAccount
		{
			[Token(Token = "0x6004E6B")]
			[Address(RVA = "0x9C9D", Offset = "0x9C9D", VA = "0x9C9D", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004E6C RID: 20076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E6C")]
		[Address(RVA = "0x1F1B", Offset = "0x1F1B", VA = "0x1F1B")]
		public AuchanArtifactData(AuchanItem auchanItem, CacheManager cacheManager, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Auchan_Model_AuchanArtifactData___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5986d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Model_AuchanArtifactData_TypeInfo);
		    DAT_ram_00a5986d = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Auchan_Model_AuchanArtifactData_TypeInfo);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Auchan_Model_AuchanArtifactData___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5986d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Model_AuchanArtifactData_TypeInfo);
		    DAT_ram_00a5986d = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Auchan_Model_AuchanArtifactData_TypeInfo);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06004E6D RID: 20077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E6D")]
		[Address(RVA = "0x9C9E", Offset = "0x9C9E", VA = "0x9C9E")]
		public AuchanArtifactData()
		{
		}

		// Token: 0x06004E6E RID: 20078 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004E6E")]
		[Address(RVA = "0x9C9F", Offset = "0x9C9F", VA = "0x9C9F")]
		internal static AuchanArtifactData CreateEmpty()
		{
		/* --- GHIDRA: CreateEmpty ---
		undefined4 Gameplay_Auchan_Model_AuchanArtifactData__CreateEmpty(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5986e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a5986e = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x1c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x8107c53a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x8107c53a:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/

			return null;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_DataChangedEvent ---
		void Gameplay_Auchan_Model_AuchanArtifactData__add_DataChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5986a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5986a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 8,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_Backtime ---
		undefined4 Gameplay_Auchan_Model_AuchanArtifactData__get_Backtime(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  undefined4 uVar3;
		  int iVar4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5986b == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_IActionInfo_TypeInfo);
		    DAT_ram_00a5986b = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x20);
		  if (param1_00 == (int *)0x0) {
		    uVar3 = 0;
		  }
		  else {
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Protocol_IActionInfo_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8107a23c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Protocol_IActionInfo_TypeInfo,0);
		code_r0x8107a23c:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  }
		  return uVar3;
		}
		*/

}
