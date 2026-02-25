using System;
using System.Collections;
using Com.TheFallenGames.OSA.CustomAdapters.TableView;
using Com.TheFallenGames.OSA.CustomAdapters.TableView.Basic;
using Il2CppDummyDll;

namespace Your.Namespace.Here.UniqueStringHereToAvoidNamespaceConflicts.Tables
{
	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	public class BasicTableAdapter : TableAdapter<TableParams, TupleViewsHolder, TupleViewsHolder>
	{
		// Token: 0x060003B0 RID: 944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x57DF", Offset = "0x57DF", VA = "0x57DF", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x57E0", Offset = "0x57E0", VA = "0x57E0")]
		public void LoadDataSync()
		{
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x57E1", Offset = "0x57E1", VA = "0x57E1")]
		public void LoadBufferedDataSync()
		{
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x57E2", Offset = "0x57E2", VA = "0x57E2")]
		public void LoadBufferedDataAsync()
		{
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x57E3", Offset = "0x57E3", VA = "0x57E3")]
		private ITableColumns RetrieveColumns()
		{
			return null;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x57E4", Offset = "0x57E4", VA = "0x57E4")]
		private void ReadDataFromServerInto(BasicTuple[] into, int firstItemIndex, int countToRead, Action onDone)
		{
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x57E5", Offset = "0x57E5", VA = "0x57E5")]
		private IEnumerator SimulateReadDataFromServerIntoExistingTuples_Coroutine(BasicTuple[] into, int firstItemIndex, int countToRead, Action onDone)
		{
			return null;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x57E6", Offset = "0x57E6", VA = "0x57E6")]
		private void ReadRandomTuples(ITuple[] into, int firstItemIndex, int numTuples)
		{
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x57E7", Offset = "0x57E7", VA = "0x57E7")]
		private void ReadRandomValueIntoTuple(ITableColumns columnsModel, int itemIndex, ITuple tuple, Random random)
		{
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x57E8", Offset = "0x57E8", VA = "0x57E8")]
		public BasicTableAdapter()
		{
		}

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0xD8")]
		private string[] _RandomStrings;
	}
}
