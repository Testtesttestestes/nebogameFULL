using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Discounts.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Dic;

namespace Gameplay.Isles.Base.Model
{
	// Token: 0x02000CFD RID: 3325
	[Token(Token = "0x2000CFD")]
	public class BaseIsleModel : AbstractModel
	{
		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x0600511E RID: 20766 RVA: 0x0000ECE8 File Offset: 0x0000CEE8
		[Token(Token = "0x1700106C")]
		public ulong Id
		{
			[Token(Token = "0x600511E")]
			[Address(RVA = "0x9F0E", Offset = "0x9F0E", VA = "0x9F0E")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x0600511F RID: 20767 RVA: 0x0000ED00 File Offset: 0x0000CF00
		// (set) Token: 0x06005120 RID: 20768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700106D")]
		public bool IsDisposed
		{
			[Token(Token = "0x600511F")]
			[Address(RVA = "0x9F0F", Offset = "0x9F0F", VA = "0x9F0F")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005120")]
			[Address(RVA = "0x9F10", Offset = "0x9F10", VA = "0x9F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x06005121 RID: 20769 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005122 RID: 20770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700106E")]
		public IDictProvider DictProvider
		{
			[Token(Token = "0x6005121")]
			[Address(RVA = "0x9F11", Offset = "0x9F11", VA = "0x9F11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005122")]
			[Address(RVA = "0x9F12", Offset = "0x9F12", VA = "0x9F12")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x06005123 RID: 20771 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700106F")]
		public Dictionaries Dictionaries
		{
			[Token(Token = "0x6005123")]
			[Address(RVA = "0x9F13", Offset = "0x9F13", VA = "0x9F13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x06005124 RID: 20772 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005125 RID: 20773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001070")]
		[CanBeNull]
		public IDiscountHandler DiscountHandler
		{
			[Token(Token = "0x6005124")]
			[Address(RVA = "0x9F14", Offset = "0x9F14", VA = "0x9F14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005125")]
			[Address(RVA = "0x9F15", Offset = "0x9F15", VA = "0x9F15")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x06005126 RID: 20774 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005127 RID: 20775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001071")]
		public Dictionary<uint, BaseBuildingData> Buildings
		{
			[Token(Token = "0x6005126")]
			[Address(RVA = "0x9F16", Offset = "0x9F16", VA = "0x9F16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005127")]
			[Address(RVA = "0x9F17", Offset = "0x9F17", VA = "0x9F17")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x06005128 RID: 20776 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005129 RID: 20777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001072")]
		public IGame Game
		{
			[Token(Token = "0x6005128")]
			[Address(RVA = "0x9F18", Offset = "0x9F18", VA = "0x9F18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005129")]
			[Address(RVA = "0x9F19", Offset = "0x9F19", VA = "0x9F19")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600512A RID: 20778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600512A")]
		[Address(RVA = "0x9F1A", Offset = "0x9F1A", VA = "0x9F1A")]
		public BaseIsleModel(UserData user, ulong id, IDictProvider dictionaries, IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_Base_Model_BaseIsleModel___ctor(int param1,undefined4 param2)
		
		{
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  *(undefined1 *)(param1 + 0x18) = 1;
		  *(undefined8 *)(param1 + 0x1c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600512B RID: 20779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600512B")]
		[Address(RVA = "0x9F1B", Offset = "0x9F1B", VA = "0x9F1B", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x0600512C RID: 20780 RVA: 0x0000ED18 File Offset: 0x0000CF18
		// (set) Token: 0x0600512D RID: 20781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001073")]
		public bool IsCurrentIsle
		{
			[Token(Token = "0x600512C")]
			[Address(RVA = "0x9F1C", Offset = "0x9F1C", VA = "0x9F1C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600512D")]
			[Address(RVA = "0x9F1D", Offset = "0x9F1D", VA = "0x9F1D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600512E RID: 20782 RVA: 0x0000ED30 File Offset: 0x0000CF30
		[Token(Token = "0x600512E")]
		[Address(RVA = "0x9F1E", Offset = "0x9F1E", VA = "0x9F1E")]
		public uint GetBuildingLevel(uint typeId)
		{
		/* --- GHIDRA: GetBuildingLevel ---
		uint Gameplay_Isles_Base_Model_BaseIsleModel__GetBuildingLevel
		               (int param1,undefined4 param2,undefined4 *param3,undefined4 param4)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  if (DAT_ram_00a58cec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__);
		    DAT_ram_00a58cec = '\x01';
		  }
		  iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0x24),param2,param3,
		                     Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__
		                    );
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    iVar1 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(*param3,0);
		    uVar2 = (uint)(iVar1 != 0);
		  }
		  return uVar2;
		}
		*/

			return 0U;
		}

		// Token: 0x0600512F RID: 20783 RVA: 0x0000ED48 File Offset: 0x0000CF48
		[Token(Token = "0x600512F")]
		[Address(RVA = "0x9F1F", Offset = "0x9F1F", VA = "0x9F1F")]
		public bool TryGetConstructedBuilding(uint buildingType, out BaseBuildingData building)
		{
			return default(bool);
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_DictProvider ---
		undefined4 Gameplay_Isles_Base_Model_BaseIsleModel__set_DictProvider(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58cea == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a58cea = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x1c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80f9701a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80f9701a:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: set_Game ---
		void Gameplay_Isles_Base_Model_BaseIsleModel__set_Game
		               (int param1,undefined4 param2,undefined8 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0x1c) = param4;
		  *(undefined8 *)(param1 + 0x10) = param3;
		  *(undefined4 *)(param1 + 0x28) = param5;
		  return;
		}
		*/


		/* --- GHIDRA: set_IsCurrentIsle ---
		undefined4
		Gameplay_Isles_Base_Model_BaseIsleModel__set_IsCurrentIsle
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_4;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a58ceb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__);
		    DAT_ram_00a58ceb = '\x01';
		  }
		  local_4 = 0;
		  if ((*(int *)(param1 + 0x24) != 0) &&
		     (iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                        (*(int *)(param1 + 0x24),param2,&local_4,
		                         Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__
		                        ), iVar1 != 0)) {
		    uVar2 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(local_4,0);
		  }
		  return uVar2;
		}
		*/

}
