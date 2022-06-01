namespace LearningProject
{
    internal class CustomException : Exception
    {
        public CustomException(string message)
        {
        }
    }

    class TestException
    {
        private string tryException()
        {
            try
            {
                // Code to try goes here.
            }
            catch (CustomException ex)
            {
                // Code to handle the exception goes here.
                // Only catch exceptions that you know how to handle.
                // Never catch base class System.Exception without
                // rethrowing it at the end of the catch block.
                throw new ArgumentOutOfRangeException("Parameter index is out of range.", ex);
            }
            catch (IndexOutOfRangeException e)
            {
                throw new ArgumentOutOfRangeException(
                    "Parameter index cannot be greater than the array size.", e);
            }
            finally
            {
                // Code to execute after the try (and possibly catch) blocks
                // A finally block enables you to clean up actions that are performed in a try block.
                // If present, the finally block executes last, after the try block and any matched catch block.
                // A finally block always runs, whether an exception is thrown or a catch block matching the exception type is found.

            }

            return "test";
        }

        private static void TestThrow()
        {
            throw new CustomException("Custom exception in TestThrow()");
        }

    }

}
